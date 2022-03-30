using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NarwhalTest.Api.EndPoints;
using NarwhalTest.Application;
using NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos;
using NarwhalTest.NarwhalServiceClient.Options;
using NarwhalTest.Persistence;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .Configure<NarwhalServiceClientOptions>(builder.Configuration.GetSection("NarwhalServiceClientOptions"))
    .AddApplicationServices()
    .AddPersistenceServices()
    .BuildServiceProvider();

var app = builder.Build();

app.MapTrackingInfosEndPoints();
app.MapGet("/", (IConfiguration config, IOptions<NarwhalServiceClientOptions> options) => new
{
    info = "Quick end point to show currently running configs",
    TestConfig = config.GetSection("TestConfig").Value,
    NarwhalServiceClientOptions = config.GetSection("NarwhalServiceClientOptions"),
    NarwhalServiceClientOptions__BaseUrl = config.GetSection("NarwhalServiceClientOptions:BaseUrl"),
    InjectedNarwhalService = options.Value
});

app.Run();
