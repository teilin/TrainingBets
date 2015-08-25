using Microsoft.AspNet.Authentication.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingBets.Authentication
{
    public interface IRunkeeperAuthenticationNotifications : IOAuthAuthenticationNotifications
    {
        Task Authenticated(RunkeeperAuthenticatedContext context);
    }
}
