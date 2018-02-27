# gbfs.net

[![Build Status](https://travis-ci.org/syncromatics/gbfs.net.svg?branch=master)](https://travis-ci.org/syncromatics/gbfs.net)

Library to interact with General Bikeshare Feed Specification (GBFS) resources

More information on the GBFS specification at https://github.com/NABSA/gbfs

## Quickstart

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

## Contributing

Please see [CONTRIBUTING](CONTRIBUTING.md) for our guide to contributing and code of conduct.
