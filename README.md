# App Metrics Concurrency <img src="http://app-metrics.io/logo.png" alt="App Metrics" width="50px"/> 
[![Official Site](https://img.shields.io/badge/site-appmetrics-blue.svg?style=flat-square)](http://app-metrics.io/getting-started/intro.html) [![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg?style=flat-square)](https://opensource.org/licenses/Apache-2.0)

Provides useful structures for performing efficient concurrent operations used my [App Metrics](https://github.com/alhardy/AppMetrics) but can be used stand alone.

## Latest Builds, Packages & Repo Stats

|Branch|AppVeyor|Travis|Coverage|
|------|:--------:|:--------:|:--------:|
|dev|[![AppVeyor](https://img.shields.io/appveyor/ci/alhardy/Concurrency/dev.svg?style=flat-square&label=appveyor%20build)](https://ci.appveyor.com/project/alhardy/Concurrency/branch/dev)|[![Travis](https://img.shields.io/travis/alhardy/Concurrency/dev.svg?style=flat-square&label=travis%20build)](https://travis-ci.org/alhardy/Concurrency)|[![Coveralls](https://img.shields.io/coveralls/alhardy/Concurrency/dev.svg?style=flat-square)](https://coveralls.io/github/alhardy/Concurrency?branch=dev)
|master|[![AppVeyor](https://img.shields.io/appveyor/ci/alhardy/Concurrency/master.svg?style=flat-square&label=appveyor%20build)](https://ci.appveyor.com/project/alhardy/Concurrency/branch/master)| [![Travis](https://img.shields.io/travis/alhardy/Concurrency/master.svg?style=flat-square&label=travis%20build)](https://travis-ci.org/alhardy/Concurrency)| [![Coveralls](https://img.shields.io/coveralls/alhardy/Concurrency/master.svg?style=flat-square)](https://coveralls.io/github/alhardy/Concurrency?branch=master)|

|Package|Dev Release|Pre-Release|Release|
|------|:--------:|:--------:|:--------:|
|App.Metrics.Concurrency|[![MyGet Status](https://img.shields.io/myget/AppMetrics/v/App.Metrics.Concurrency.svg?style=flat-square)](https://www.myget.org/feed/AppMetrics/package/nuget/App.Metrics.Concurrency)|[![NuGet Status](https://img.shields.io/nuget/vpre/App.Metrics.Concurrency.svg?style=flat-square)](https://www.nuget.org/packages/App.Metrics.Concurrency/)|[![NuGet Status](https://img.shields.io/nuget/v/App.Metrics.Concurrency.svg?style=flat-square)](https://www.nuget.org/packages/App.Metrics.Concurrency/)|
----------

## How to build

[AppVeyor](https://ci.appveyor.com/project/alhardy/Concurrency/branch/master) and [Travis CI](https://travis-ci.org/alhardy/Concurrency) builds are triggered on commits and PRs to `dev` and `master` branches.

See the following for build arguments and running locally.

|Configuration|Description|Default|Environment|Required|
|------|--------|:--------:|:--------:|:--------:|
|BuildConfiguration|The configuration to run the build, **Debug** or **Release** |*Release*|All|Optional|
|PreReleaseSuffix|The pre-release suffix for versioning nuget package artifacts e.g. `beta`|*ci*|All|Optional|
|CoverWith|**DotCover** or **OpenCover** to calculate and report code coverage, **None** to skip. When not **None**, a coverage file and html report will be generated at `./artifacts/coverage`|*OpenCover*|Windows Only|Optional|
|SkipCodeInspect|**false** to run ReSharper code inspect and report results, **true** to skip. When **true**, the code inspection html report and xml output will be generated at `./artifacts/resharper-reports`|*false*|Windows Only|Optional|
|BuildNumber|The build number to use for pre-release versions|*0*|All|Optional|


### Windows

Run `build.ps1` from the repositories root directory.

```
	.\build.ps1
```

**With Arguments**

```
	.\build.ps1 --ScriptArgs '-BuildConfiguration=Release -PreReleaseSuffix=beta -CoverWith=OpenCover -SkipCodeInspect=false -BuildNumber=1'
```

### Linux & OSX

Run `build.sh` from the repositories root directory. Code Coverage reports are now supported on Linux and OSX, it will be skipped running in these environments.

```
	.\build.sh
```

**With Arguments**

```
	.\build.sh --ScriptArgs '-BuildConfiguration=Release -PreReleaseSuffix=beta -BuildNumber=1'
``` 

## How to run benchmarks

App.Metrics includes benchmarking using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet). You can find the benchmark results [here](https://github.com/alhardy/Concurrency/tree/master/benchmarks/App.Metrics.Concurrency.Benchmarks.Runner/BenchmarkDotNet.Artifacts/results).

To run, fron the solution's root:

```
	cd .\benchmarks\App.Metrics.Concurrency.Benchmarks.Runner\
	dotnet run -c "Release"
```

You'll then be prompted to choose a benchmark to run which will output a markdown file with the result in directory `.\benchmarks\App.Metrics.Concurrency.Benchmarks.Runner\BenchmarkDotNet.Artifacts\results`.

Alternatively, you can run the same benchmarks from visual studio using xUnit.net in the [benchmark project](https://github.com/alhardy/concurrency/tree/master/benchmarks/App.Metrics.Concurrency.Benchmarks).

## Contributing

See the [contribution guidlines](https://github.com/alhardy/AppMetrics/blob/master/CONTRIBUTING.md) in the [main repo](https://github.com/alhardy/AppMetrics) for details.

## Acknowledgements

***Thanks for providing free open source licensing***

* [Jetbrains](https://www.jetbrains.com/dotnet/) 
* [AppVeyor](https://www.appveyor.com/)
* [Travis CI](https://travis-ci.org/)
* [Coveralls](https://coveralls.io/)

## License

This library is release under Apache 2.0 License ( see LICENSE ) Copyright (c) 2016 Allan Hardy

See [LICENSE](https://github.com/alhardy/AppMetrics/blob/dev/LICENSE)

----------

App Metrics Concurrency is a .NET Standard port of the [ConcurrencyUtilities](https://github.com/etishor/ConcurrencyUtilities) library, including a port of Java's LongAdder and Striped64 classes.

*Metrics.NET Licensed under these terms*:
"This library is release under Apache 2.0 License ( see LICENSE ) Copyright (c) 2015 Iulian Margarintescu" see [LICENSE](https://github.com/etishor/ConcurrencyUtilities/blob/master/LICENSE)
