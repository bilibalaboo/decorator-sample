using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddSingleton<ISampleService, SampleService>()
            .AddSingleton<IRepository, StoreRepository>()
            .Decorate<IRepository, PreRepoDecoratorRepository>()
            .Decorate<IRepository, PostRepoSecondDecoratorRepository>()
            .Decorate<IRepository, PostRepoFirstDecoratorRepository>())
    .Build();

Execute(host.Services);

await host.RunAsync();

static void Execute(IServiceProvider services)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    var  service = provider.GetRequiredService<ISampleService>();
    service.SaveData();
}