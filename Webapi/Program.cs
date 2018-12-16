
using System;
using System.IO;
using System.Threading.Tasks;
using MediatR;
using MediatR.Pipeline;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Webapi.Domains;

namespace Webapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        //  private static IMediator BuildMediator()
        // {
        //     var services = new ServiceCollection();

        //     services.AddScoped<ServiceFactory>(p => p.GetService);

        //     //Pipeline
        //     services.AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
        //     services.AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestPostProcessorBehavior<,>));
        //     services.AddScoped(typeof(IMediator));

        //     services.Scan(scan => scan
        //         .FromAssembliesOf(typeof(IMediator), typeof(GetPayslip))
        //         .AddClasses()
        //         .AsImplementedInterfaces());

        //     var provider = services.BuildServiceProvider();

        //     return provider.GetRequiredService<IMediator>();
        // }
    }
}
