using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NarwhalTest.Api.EndPoints;
using NarwhalTest.Application;
using NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos;
using NarwhalTest.NarwhalServiceClient.Options;
using NarwhalTest.Persistence;
using System.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .Configure<NarwhalServiceClientOptions>(config.GetSection("NarwhalServiceClientOptions"))
    .AddApplicationServices()
    .AddPersistenceServices()
    .BuildServiceProvider();

var app = builder.Build();

app.MapTrackingInfosEndPoints();

app.Run();
