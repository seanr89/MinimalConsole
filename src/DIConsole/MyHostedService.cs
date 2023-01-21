using Microsoft.Extensions.Hosting;

namespace DIConsole;

public class MyHostedService : IHostedService
{
    
    public MyHostedService(
        IHostApplicationLifetime appLifetime)
    {
        appLifetime.ApplicationStarted.Register(OnStarted);
        appLifetime.ApplicationStopping.Register(OnStopping);
        appLifetime.ApplicationStopped.Register(OnStopped);
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("1. StartAsync has been called.");

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("4. StopAsync has been called.");

        return Task.CompletedTask;
    }

    private void OnStarted()
    {
        Console.WriteLine("2. OnStarted has been called.");
    }

    private void OnStopping()
    {
        Console.WriteLine("3. OnStopping has been called.");
    }

    private void OnStopped()
    {
        Console.WriteLine("5. OnStopped has been called.");
    }
}