using IdentityProtocols.Interface;
using IdentityProtocols.Oidc.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProtocols.Oidc.Handlers
{
    public class JwksHandler : IJwksHandler
    {        
        public JwksHandler()
        {
            
        }
       
        public async Task HandleAsync(IEndpointRequest request)
        {
            using RSA rsa = RSA.Create(); // Generate RSA key pair

            // Export the public key parameters
            RSAParameters publicKeyParameters = rsa.ExportParameters(includePrivateParameters: false);

            // Create a new JsonWebKey using the public key parameters
            var jwk = new JsonWebKey
            {
                Kty = "RSA",
                Alg = "RS256",
                Use = "sig",
                Kid = "your-key-id", // Set your key ID
                E = Base64UrlEncoder.Encode(publicKeyParameters.Exponent),
                N = Base64UrlEncoder.Encode(publicKeyParameters.Modulus)
            };

            //var rsa = RSA.Create(); // Create or load your RSA key pair
            //var rsaParameters = rsa.ExportParameters(includePrivateParameters: false);

            //var signingKey = new RsaSecurityKey(rsaParameters);
            //signingKey.KeyId = "your-key-id"; // Set a key ID

            //var jwks = new JsonWebKeySet(new List<JsonWebKey> { signingKey });
            //var jwksString = JsonConvert.SerializeObject(jwks);            
            var jwksString = JsonConvert.SerializeObject(jwk, Formatting.Indented);
            await request.Context.Response.WriteAsync(jwksString);
        }
    }
}
