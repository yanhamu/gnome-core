using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Features.Variance;
using AutoMapper;
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
            services.AddMediatR(typeof(RandomRequestHandler));
            services.AddAutoMapper();

            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterSource(new ContravariantRegistrationSource());
            
            containerBuilder.Populate(services);
            return containerBuilder.Build();
        }
    }
}