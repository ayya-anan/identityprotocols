using IdentityProtocols.Extensions;
using IdentityProtocols.Oidc.Constants;
using IdentityProtocols.Oidc.Handlers;
using IdentityProtocols.Oidc.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProtocols.Oidc
{
    public static class OidcEndpointsExtensions
    {
        public static void UseOidcEndpoints(this IApplicationBuilder applicationBuilder, IServiceProvider provider)
        {            
            var endpoints = new Dictionary<string, Type>();            
            endpoints.Add(StandardEndpointRoutes.Authorize, typeof(IOidcAuthorizeHandler));                                          
            applicationBuilder.UseDynamicEndpoints(endpoints);
        }

        public static void AddOidcEndpoints(this IServiceCollection  serviceCollection)
        {
            serviceCollection.AddScoped<IOidcAuthorizeHandler, AuthorizeHandler>();
        }
    }
    
}
