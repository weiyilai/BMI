// See https://aka.ms/new-console-template for more information

using App.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<ICalculatorService, CalculatorService>();

using IHost host = builder.Build();

Calculator(host.Services);

await host.RunAsync();


static void Calculator(IServiceProvider hostProvider)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    var service = provider.GetRequiredService<ICalculatorService>();

    Console.WriteLine($"{service.BMI(80, 190)}");
}