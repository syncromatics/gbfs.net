# Gbfs.Net

Library to interact with General Bikeshare Feed Specification (GBFS) resources

More information on the GBFS specification at https://github.com/NABSA/gbfs

## Quickstart

Add the `Gbfs.Net` package to your project:

```bash
dotnet add package Gbfs.Net
```

```csharp
// Find a GBFS feed url. This one belongs to Los Angeles Metro
var laMetroGbfsFeedUrl = "https://gbfs.bcycle.com/bcycle_lametro/gbfs.json";

// Get an instance of the Gbfs.Net client
var client = GbfsClient.GetInstance(laMetroGbfsFeedUrl);

// Get the GBFS manifest, which includes references to the different feeds of information about this bikeshare system
var manifest = await client.GetManifest();

// Determine which language to refer to in the manifest. Here, if English is available, it is being preferred.
var language = manifest.Data.ContainsKey("en") ? "en" : manifest.Data.Keys.First();

// Get the bikeshare station information (Location, name, etc.)
var stations = await manifest.GetStationInformation(client, language);

// Find all the stations on Grand Ave.
var selectedStations = stations.Data.Stations
	.Where(s => s.Address.Contains("Grand Ave"))
	.ToList();

// Get the bikeshare station status (number of bikes and docks available, etc.)
var statuses = await manifest.GetStationStatus(client, language);

// Join the station and status information on StationId
statuses.Data.Stations
	.Join(selectedStations, s => s.StationId, s => s.StationId, (status, station) => new
	{
		Station = station,
		Status = status,
	})
	.ToList()
	// Write out some information about the stations
	.ForEach(x => Console.WriteLine($"Station at {x.Station.Name} has {x.Status.NumBikesAvailable} bikes available and {x.Status.NumDocksAvailable} docks available"));
```

## Building

[![Travis](https://img.shields.io/travis/syncromatics/gbfs.net.svg)](https://travis-ci.org/syncromatics/gbfs.net)
[![NuGet](https://img.shields.io/nuget/v/Gbfs.Net.svg)](https://www.nuget.org/packages/Gbfs.Net/)
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Gbfs.Net.svg)](https://www.nuget.org/packages/Gbfs.Net/)

This library is built using .NET Core. To build:

```bash
dotnet build
```

Running the JSON Schema generator can be done via:

```bash
cd src/Gbfs.Net.JsonSchemaGenerator

# Returns help
dotnet run

# Generates schema in the artifacts folder
dotnet run -o artifacts
```

## Code of Conduct

We are committed to fostering an open and welcoming environment. Please read our [code of conduct](CODE_OF_CONDUCT.md) before participating in or contributing to this project.

## Contributing

We welcome contributions and collaboration on this project. Please read our [contributor's guide](CONTRIBUTING.md) to understand how best to work with us.

## License and Authors

[![GMV Syncromatics Engineering logo](https://secure.gravatar.com/avatar/645145afc5c0bc24ba24c3d86228ad39?size=16) GMV Syncromatics Engineering](https://github.com/syncromatics)

[![license](https://img.shields.io/github/license/syncromatics/gbfs.net.svg)](https://github.com/syncromatics/gbfs.net/blob/master/LICENSE)
[![GitHub contributors](https://img.shields.io/github/contributors/syncromatics/gbfs.net.svg)](https://github.com/syncromatics/gbfs.net/graphs/contributors)

This software is made available by GMV Syncromatics Engineering under the MIT license.