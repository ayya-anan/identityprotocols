using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityProtocols.Interface;

namespace IdentityProtocols
{
    public interface IHandler
    {
        Task HandleAsync(IEndpointRequest request);
    }
}
