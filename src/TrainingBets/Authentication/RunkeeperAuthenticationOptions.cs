using Microsoft.AspNet.Authentication.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingBets.Authentication
{
    public class RunkeeperAuthenticationOptions : OAuthAuthenticationOptions<IRunkeeperAuthenticationNotifications>
    {
        public RunkeeperAuthenticationOptions()
        {
            
        }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }
    }
}
