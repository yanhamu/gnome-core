using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Features.Variance;
using Gnome.Services;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gnome.Web.Configuration
{
    public static class DiConfiguration
    {
        public static IContainer CreateContainer(IServiceCollection services, IConfiguration configuration)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterSource(new ContravariantRegistrationSource());
            services.AddMediatR(typeof(RandomRequestHandler));
            containerBuilder.Populate(services);
            return containerBuilder.Build();
        }
    }
}