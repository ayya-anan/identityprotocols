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
        public static void UseOidcEndpoints(this IApplicationBuilder applicationBuilder)
        {
            var endpoints = new Dictionary<string, Type>
            {
                { StandardEndpointRoutes.Authorize, typeof(IOidcAuthorizeHandler) },
                { StandardEndpointRoutes.EndSession, typeof(IEndSessionHandler) },
                { StandardEndpointRoutes.Jwks, typeof(IJwksHandler) },
                { StandardEndpointRoutes.Token, typeof(ITokenHandler) },
                { StandardEndpointRoutes.UserInfo, typeof(IUserInfoHandler) },
            };
            applicationBuilder.UseDynamicEndpoints(endpoints);
        }

        public static void AddOidcEndpoints(this IServiceCollection  serviceCollection)
        {
            serviceCollection.AddScoped<IOidcAuthorizeHandler, AuthorizeHandler>();
            serviceCollection.AddScoped<IEndSessionHandler, EndSessionHandler>();
            serviceCollection.AddScoped<IJwksHandler, JwksHandler>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
            serviceCollection.AddScoped<IUserInfoHandler, UserInfoHandler>();
        }
    }
    
}
