using IdentityProtocols.Request;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProtocols.Middleware
{
    public class DynamicEndpointMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly Dictionary<string, Type> _handler;
        //private readonly IServiceProvider _serviceProvider;

        public DynamicEndpointMiddleware(RequestDelegate next, Dictionary<string, Type> handler)
        {
            _next = next;
            _handler = handler;
           // _serviceProvider = serviceProvider;
        }
    

        public async Task Invoke(HttpContext context, IServiceProvider serviceProvider)
        {
            if (context.Request.Path.HasValue && _handler.TryGetValue(context.Request.Path.Value.TrimStart(UrlConstants.Seprater), out var handlerType))
            {
                var handler = serviceProvider.GetService(handlerType) as IEndpointHandler;
                if (handler != null)
                {
                    var request = new EndpointRequest(context);
                    await handler.HandleAsync(request);
                    return;
                }
            }

            await _next(context);
        }
    }
}
