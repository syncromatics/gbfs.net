using CommandLine;

namespace Gbfs.Net.JsonSchemaGenerator
{
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