using IdentityProtocols.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace IdentityProtocols.Extensions
{
    public static class DynamicEndpointMiddlewareExtensions
    {
        public static IApplicationBuilder UseDynamicEndpoints(this IApplicationBuilder builder, Dictionary<string, Type> handlerMapping)
        {
            return builder.UseMiddleware<DynamicEndpointMiddleware>(handlerMapping);
        }
    }
}
