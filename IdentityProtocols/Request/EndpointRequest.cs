using IdentityProtocols.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProtocols.Request
{
    public class EndpointRequest: IEndpointRequest
    {
        private readonly HttpContext _context;
        public EndpointRequest(HttpContext context)
        {
            _context = context;
        }

        public HttpContext Context => _context;
    }
}
