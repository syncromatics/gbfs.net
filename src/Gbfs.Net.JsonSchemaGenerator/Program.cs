using System;
using System.IO;
using System.Linq;
using System.Reflection;
using CommandLine;
using CommandLine.Text;
using Gbfs.Net.v1;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;

namespace Gbfs.Net.JsonSchemaGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var error = false;
            var options = CommandLine.Parser.Default.ParseArguments<Options>(args)
                .MapResult(x => x, x => {
                    error = true;
                    return new Options();
                });

            if (error)
            {
                Console.Error.WriteLine("Invalid arguments");
                return;
            }

            Console.WriteLine($"Generating schemas for version {options.SpecificationVersion}");
            var schemaGenerator = new JSchemaGenerator();
            schemaGenerator.ContractResolver = GbfsClient.JsonSerializerSettings.ContractResolver;
            schemaGenerator.GenerationProviders.Add(new StringEnumGenerationProvider());
            switch (options.SpecificationVersion)
            {
                case SpecificationVersion.v1:
                    var types = LoadAssembly<Gbfs.Net.v1.Manifest>().GetTypes()
                        .Select(t => t.GetTypeInfo())
                        .Where(t => !t.IsAbstract && !t.IsSealed)
                        .Where(t => t.GetInterfaces()
                            .Any(i => i.GetGenericTypeDefinition() == typeof(IGbfsFile<>)))
                        .Select(t => t.AsType());

                    var outputDirectory = options.OutputDirectory.Trim();
                    foreach (var type in types)
                    {
                        if (!Directory.Exists(outputDirectory))
                        {
                            Directory.CreateDirectory(outputDirectory);
                        }

                        var schema = schemaGenerator.Generate(type);
                        var fileName = new SnakeCaseNamingStrategy().GetPropertyName(type.Name, false);
                        if (type == typeof(Manifest))
                        {
                            // Manually set filename to match spec
                            fileName = "gbfs";

                            // Rearrange Json.NET's handling for Dictionaries to allow for a JSON Schema pattern property
                            var dataSchema = schema.Properties["data"];
                            var languageFeedSchema = dataSchema.AdditionalProperties;
                            languageFeedSchema.MinimumProperties = 1;
                            dataSchema.PatternProperties[Resources.ItefSingleLanguageTagPattern] = languageFeedSchema;
                            dataSchema.AdditionalProperties = new JSchema();
                        }
                        var path = Path.Combine(outputDirectory, $"{fileName}.json");
                        File.WriteAllText(path, schema.ToString());
                        Console.WriteLine($"Wrote schema for {type.Name} to {path}...");
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(SpecificationVersion), "Specification version not supported");
            }
        }

        private static Assembly LoadAssembly<TSeed>()
        {
            var manifestType = typeof(TSeed);
            var assemblyNameString = string.Join(",", manifestType.AssemblyQualifiedName.Split(',').Skip(1));
            var assemblyName = new AssemblyName(assemblyNameString);
            return System.Reflection.Assembly.Load(assemblyName);
        }
    }

    public enum SpecificationVersion
    {
        v1 = 1,
    }

    public class Options
    {
        [Option('v', "version",
            Default = SpecificationVersion.v1,
            HelpText = "Version of the specification to generate JSON schemas for")]
        public SpecificationVersion SpecificationVersion { get; set; }

        [Option('o', "output",
            Required = true,
            HelpText = "Directory to write JSON schemas to")]
        public string OutputDirectory {get;set;}
    }
}
