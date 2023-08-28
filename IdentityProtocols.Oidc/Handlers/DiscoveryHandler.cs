using IdentityProtocols.Interface;
using IdentityProtocols.Oidc.Configure;
using IdentityProtocols.Oidc.Constants;
using IdentityProtocols.Oidc.Interface;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace IdentityProtocols.Oidc.Handlers
{
    public class DiscoveryHandler : IDiscoveryHandler
    {        
        public DiscoveryHandler()
        {
            
        }
       
        public async Task HandleAsync(IEndpointRequest request)
        {
            var hostUrl = "https://localhost:7071/";
            var configuration = new OidcServerConfiguration
            {
                Issuer = "Testissuer",
                SubjectTypes = new string[] { "public"},
                ResponseTypes = new string[] { "code", "id_token", "token id_token" },
                IdTokenSigningAlgorithms = new string[] { "RS256" },
                Scopes = new string[] { "openid", "profile", "email", "offline_access" },
                SupportRequestParameter = true,
                SupportRequestUri = true,

                AuthorizeEndpoint= $"{hostUrl}{EndpointRoutes.Authorize}",
                TokenEndpoint = $"{hostUrl}{EndpointRoutes.Token}",
                UserInfoEndpoint = $"{hostUrl}{EndpointRoutes.UserInfo}",
                JwksEndpoint = $"{hostUrl}{EndpointRoutes.Jwks}", //TODO: this must match the jwks keys
                EndSessionEndpoint = $"{hostUrl}{EndpointRoutes.EndSession}",
            };

            var metadata = JsonConvert.SerializeObject(configuration);
            await request.Context.Response.WriteAsync(metadata);
        }
    }
}
