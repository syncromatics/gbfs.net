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

namespace Gbfs.Net.JsonSchemaGenrator
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
            switch (options.SpecificationVersion)
            {
                case SpecificationVersion.v1:
                    var types = LoadAssembly<Gbfs.Net.v1.Manifest>().GetTypes()
                        .Select(t => t.GetTypeInfo())
                        .Where(t => !t.IsAbstract && !t.IsSealed)
                        .Where(t => t.GetInterfaces()
                            .Any(i => i.GetGenericTypeDefinition() == typeof(IGbfsFile<>)))
                        .Select(t => t.AsType());

                    foreach (var type in types)
                    {
                        if (!Directory.Exists(options.OutputDirectory))
                        {
                            Directory.CreateDirectory(options.OutputDirectory);
                        }

                        var jsonSchema = schemaGenerator.Generate(type).ToString();
                        var fileName = new SnakeCaseNamingStrategy().GetPropertyName(type.Name, false);
                        if (type == typeof(Manifest))
                        {
                            fileName = "gbfs";
                        }
                        var path = Path.Combine(options.OutputDirectory, $"{fileName}.json");
                        File.WriteAllText(path, jsonSchema);
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

        //[HelpOption]
        //public string GetUsage()
        //{
        //    return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        //}
    }
}
