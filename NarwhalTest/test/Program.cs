using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NarwhalService.Client;
using NarwhalService.Client.Configurations;
using test;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var serviceProvider = new ServiceCollection()
    .AddSingleton<Application>()
    .AddNarwhalClientServices(config.GetSection("NarwhalServiceClientOptions").Get<NarwhalServiceClientConfiguration>())
    .BuildServiceProvider();

await serviceProvider.GetService<Application>()!.Run();