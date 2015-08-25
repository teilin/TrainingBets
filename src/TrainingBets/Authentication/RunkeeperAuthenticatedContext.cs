using Microsoft.AspNet.Authentication.OAuth;
using Microsoft.AspNet.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingBets.Authentication
{
    public class RunkeeperAuthenticatedContext : OAuthAuthenticatedContext
    {
        public RunkeeperAuthenticatedContext(HttpContext context, OAuthAuthenticationOptions options, JObject user, TokenResponse tokens)
            : base(context, options, user, tokens)
        {
            
        }

        public string Email { get; }

        public string Id { get; }
    }
}
