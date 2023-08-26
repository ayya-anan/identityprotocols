using IdentityProtocols.Oidc.Interface;
using IdentityProtocols.Request;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProtocols.Oidc.Request
{
    public class AuthorizeEndpointRequest : EndpointRequest
    {
        public AuthorizeEndpointRequest(HttpContext context): base(context)
        {

        }
    }
}
