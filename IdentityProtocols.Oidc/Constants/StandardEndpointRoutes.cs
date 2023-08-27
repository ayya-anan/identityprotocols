using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProtocols.Oidc.Constants
{
    public static class StandardEndpointRoutes
    {
        /// <summary>
        /// The URL where the authorization process is initiated.
        /// </summary>
        public static string Authorize = "auth";
        /// <summary>
        /// The URL where the client exchanges the authorization code for tokens.
        /// </summary>
        public static string Token = "token";
        /// <summary>
        /// The URL where the client can retrieve additional user information.
        /// </summary>
        public static string UserInfo = "userinfo";
        /// <summary>
        /// The URL to end the user's session (logout).
        /// </summary>
        public static string EndSession = "logout";
        /// <summary>
        /// The URL to retrieve the JSON Web Key Set containing the public keys.
        /// </summary>
        public static string Jwks= "jwks";                
    }
}
