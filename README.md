[![NuGet](https://img.shields.io/nuget/v/Ardalis.ListStartupServices.svg)](https://www.nuget.org/packages/Ardalis.ListStartupServices)[![NuGet](https://img.shields.io/nuget/dt/Ardalis.ListStartupServices.svg)](https://www.nuget.org/packages/Ardalis.ListStartupServices)
[![Build and Test .NET CI](https://github.com/ardalis/AspNetCoreStartupServices/actions/workflows/dotnet.yml/badge.svg)](https://github.com/ardalis/AspNetCoreStartupServices/actions/workflows/dotnet.yml)

# ASP.NET Core ListStartupServices Middleware Package

A diagnostic middleware [nuget package](https://www.nuget.org/packages/Ardalis.ListStartupServices) for listing all services registered with Startup in an ASP.NET Core applications.

# Getting Started

1. Install the nuget package.
1. Add the following at **the bottom of** Startup's `ConfigureServices` method:

```
services.Configure<ServiceConfig>(config =>
{
    config.Services = new List<ServiceDescriptor>(services);
    
    // optional - default path to view services is /listallservices - recommended to choose your own path
    config.Path = "/mylistallservicespath";
});
```
1. Add the following to your Configure method (in an if block so it only runs in dev environemnt)
```
if (env.IsDevelopment())
{
    app.UseShowAllServicesMiddleware();
    app.UseDeveloperExceptionPage();
}
```

If it's working you should see output like this showing all of your services:

![image](https://user-images.githubusercontent.com/782127/52003616-0e497b80-2493-11e9-856c-1d4ef9207be0.png)

# Reference

- [Original Sample Article](https://ardalis.com/how-to-list-all-services-available-to-an-asp-net-core-app)
- [Screencast of Extracting Middleware and Publishing to Nuget.org](https://www.youtube.com/watch?v=6-WcxBLyIes)
- [Follow ardalis on twitch.tv](https://www.twitch.tv/ardalis)

