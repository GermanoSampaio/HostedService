using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace HostedService
{
    //public class HelloWorldHostedService : IHostedService
    public class HelloWorldHostedService : BackgroundService
    {
        // private Timer _timer;
        // Task IHostedService.StartAsync(CancellationToken cancellationToken)
        // {
        //     _timer = new Timer(HelloWorld, null, 0 , 10000);
        //     return Task.CompletedTask;
        // }

        // void HelloWorld(object state)
        // {
        //     Debug.WriteLine("HelloWorld!");
        // }

        // Task IHostedService.StopAsync(CancellationToken cancellationToken)
        // {
        //     _timer?.Change(Timeout.Infinite,0);
        //     return Task.CompletedTask;
        // }
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Debug.WriteLine("Hello World");
                await Task.Delay(10000,stoppingToken);
            }
        }
    }
}