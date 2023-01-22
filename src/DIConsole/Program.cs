using DIConsole;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<MyInjectedClass>();
        services.AddSingleton<Main>();
        services.AddHostedService<MyHostedService>();
    }).Build();

var logger = host.Services.GetRequiredService<ILogger<Program>>();
logger.LogDebug("Host created.");
host.Services.GetService<MyInjectedClass>().Execute().Wait();