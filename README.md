# Accuweather Api Client

| Windows | Linux | OS X |
| --- | --- | --- |
| [![Build status](https://travis-ci.org/dmitryershov0/accuweather.svg?branch=master)](https://travis-ci.org/github/dmitryershov0/accuweather) | [![Build Status](https://travis-ci.org/dmitryershov0/accuweather.svg?branch=master)](https://travis-ci.org/github/dmitryershov0/accuweather) | [![Build Status](https://travis-ci.org/dmitryershov0/accuweather.svg?branch=master)](https://travis-ci.org/github/dmitryershov0/accuweather) |

1️⃣ [Location Api Client](https://github.com/dmitryershov0/accuweather-locations).
📜 https://developer.accuweather.com/accuweather-locations-api/apis

2️⃣ [Current Conditions Api Client](https://github.com/dmitryershov0/accuweather-current). 
📜 https://developer.accuweather.com/accuweather-current-conditions-api/apis

3️⃣ [Forecast Api Client](https://github.com/dmitryershov0/accuweather-forecast).
📜 https://developer.accuweather.com/accuweather-forecast-api/apis

4️⃣ [Indices Api Client](https://github.com/dmitryershov0/accuweather-indices). 
📜 https://developer.accuweather.com/accuweather-indices-api/apis


<hr>


## Download

Accuweather Api Client is available on [NuGet](https://www.nuget.org/packages/Accuweather/).

<hr>

## Usage

```csharp
using Accuweather;


public class Startup
{

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IAccuweatherApi>(l => new AccuweatherApi("YOUR_API_KEY", "en-us");
    }
}

```
```csharp
using Accuweather;


public class SampleController : Controller
{
    private readonly IAccuweatherApi _accuweatherApi;
    
    public void SampleController(ILocationsApi accuweatherApi)
    {
        _accuweatherApi = accuweatherApi;
    }
    
    public async Tasnk<ActionResult> GetRegionList() 
    {
        var regionList = await _accuweatherApi.Locations.GetRegionList();
        return Json(regionList , JsonRequestBehavior.AllowGet);
    }
}

```
