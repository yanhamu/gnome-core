using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Gnome.Web.Configuration
{
    public static class CorsConfiguration
    {
        public static CorsPolicy BuildAllReadyOpenCorsPolicy()
        {
            var corsBuilder = new CorsPolicyBuilder();

            corsBuilder.AllowAnyHeader();
            corsBuilder.AllowAnyMethod();
            // Revisit this and build a whitelist of IP addresses
            corsBuilder.AllowAnyOrigin();
            corsBuilder.AllowCredentials();

            return corsBuilder.Build();
        }
    }
}
