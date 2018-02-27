var configuration = Argument("configuration", "Release");

Task("Clean")
    .Does(() =>
    {
        CleanDirectories(GetDirectories("./src/**/bin")
            .Concat(GetDirectories("./src/**/obj")));
    });

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        DotNetCoreRestore();
    });

Task("Compile")
    .IsDependentOn("Restore")
    .Does(() =>
    {
        var buildSettings = new ProcessSettings
        {
            Arguments = $"/property:Configuration={configuration}",
        };

        using(var process = StartAndReturnProcess("msbuild", buildSettings))
        {
            process.WaitForExit();
            var exitCode = process.GetExitCode();
            if(exitCode != 0)
                throw new Exception("Build Failed.");
        }
    });

Task("ContainerBuild")
    .IsDependentOn("Compile");

Task("ContainerRunSchemaGenerator")
    .IsDependentOn("ContainerBuild")
    .Does(() =>
    {
        var schemaGeneratorSettings = new ProcessSettings
        {
            Arguments = $"src/Gbfs.Net.JsonSchemaGenerator/bin/{configuration}/net46/Gbfs.Net.JsonSchemaGenerator.exe -v 1 -o artifacts/",
        };

        using(var process = StartAndReturnProcess("mono", schemaGeneratorSettings))
        {
            process.WaitForExit();
            var exitCode = process.GetExitCode();
            if(exitCode != 0)
                throw new Exception("Schema Generation Failed.");
        }
    });