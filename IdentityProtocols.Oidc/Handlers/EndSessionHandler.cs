using IdentityProtocols.Interface;
using IdentityProtocols.Oidc.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProtocols.Oidc.Handlers
{
    public class EndSessionHandler : IEndSessionHandler
    {        
        public EndSessionHandler()
        {
            
        }
       
        public async Task HandleAsync(IEndpointRequest request)
        {
            await request.Context.Response.WriteAsync("This is from end session handler");
        }
    }
}
