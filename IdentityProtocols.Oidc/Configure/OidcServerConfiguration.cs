using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace IdentityProtocols.Oidc.Configure
{
    public class OidcServerConfiguration
    {
        public OidcServerConfiguration()
        {

        }
        [JsonProperty(PropertyName = "issuer")]
        public string Issuer { get; set; }
        [JsonProperty(PropertyName ="subject_types_supported")]
        public string[] SubjectTypes { get; set; }
        [JsonProperty(PropertyName ="response_types_supported")]
        public string[] ResponseTypes { get; set; }
        [JsonProperty(PropertyName ="id_token_signing_alg_values_supported")]
        public string[] IdTokenSigningAlgorithms { get; set; }
        [JsonProperty(PropertyName ="scopes_supported")]
        public string[] Scopes { get; set; }
        [JsonProperty(PropertyName ="request_parameter_supported")]
        public bool SupportRequestParameter { get; set; }
        [JsonProperty(PropertyName ="request_uri_parameter_supported")]
        public bool SupportRequestUri { get; set; }


        [JsonProperty(PropertyName ="authorization_endpoint")]
        public string AuthorizeEndpoint { get; set; }
        [JsonProperty(PropertyName ="token_endpoint")]
        public string TokenEndpoint { get; set; }
        [JsonProperty(PropertyName ="userinfo_endpoint")]
        public string UserInfoEndpoint { get; set; }
        [JsonProperty(PropertyName ="jwks_uri")]
        public string JwksEndpoint { get; set; }
        [JsonProperty(PropertyName ="end_session_endpoint")]
        public string EndSessionEndpoint { get; set; }

    }
}
