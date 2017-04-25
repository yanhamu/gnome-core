using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Features.Variance;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gnome.Web.Configuration
{
    public static class DIConfiguration
    {
        public static IContainer CreateContainer(IServiceCollection services, IConfiguration configuration)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterSource(new ContravariantRegistrationSource());

            containerBuilder
                .RegisterType<Services.RandomService>()
                .As<Services.IRandomService>();

            containerBuilder.Populate(services);
            return containerBuilder.Build();
        }
    }
}
