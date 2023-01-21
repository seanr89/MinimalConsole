using DIConsole;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;


var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<MyInjectedClass>();
        services.AddHostedService<MyHostedService>();
    });

var builder = host.Build();
builder.Services.GetService<MyInjectedClass>().Execute().Wait();