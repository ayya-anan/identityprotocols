using System.Security.Cryptography;

namespace IdentityProtocols.Oidc.Handlers
{
    internal class RsaSecurityKey
    {
        private RSAParameters rsaParameters;

        public RsaSecurityKey(RSAParameters rsaParameters)
        {
            this.rsaParameters = rsaParameters;
        }
    }
}