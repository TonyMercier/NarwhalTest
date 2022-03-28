using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NarwhalTest.Application;
using NarwhalTest.NarwhalServiceClient;
using NarwhalTest.NarwhalServiceClient.Options;
using NarwhalTest.Persistence;
using test;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var serviceProvider = new ServiceCollection()
    .AddSingleton<Application>()
    .AddApplicationServices()
    .AddPersistenceServices(config.GetSection("NarwhalServiceClientOptions").Get<NarwhalServiceClientOptions>())
    .BuildServiceProvider();

await serviceProvider.GetService<Application>()!.Run();