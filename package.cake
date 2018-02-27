#addin nuget:?package=Cake.Git&version=0.16.1
using System.Text.RegularExpressions;

var outputDirectory = Directory("packages");

Task("CleanPackages")
    .Does(() => {
        CleanDirectory(outputDirectory);
    });

Task("PackageNuget")
    .IsDependentOn("CleanPackages")
    .IsDependentOn("GetVersion")
    .Does(() =>
    {
        var assemblyInfo = ParseAssemblyInfo(File("./src/Gbfs.Net/AssemblyInfo.cs"));

        var packageSettings = new NuGetPackSettings
        {
            Version = assemblyInfo.AssemblyInformationalVersion,
            Properties = new Dictionary<string, string> 
            {
                { "configuration", configuration }
            },
            OutputDirectory = outputDirectory,
        };

        NuGetPack(File("./src/Gbfs.Net/Gbfs.Net.nuspec"), packageSettings);
    });

Task("PublishNuget")
    .IsDependentOn("PackageNuget")
    .Does(() =>
    {
        var package = GetFiles($"{outputDirectory}/*.nupkg").Single();

        NuGetPush(package, new NuGetPushSettings
        {
            Source = "https://www.nuget.org/api/v2/package",
            ApiKey = EnvironmentVariable("NUGET_API_KEY"),
        });
    });