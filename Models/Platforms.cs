using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SocialDashBackEnd.Models
{
    public class Platforms
    {
        public SocialsModel? Facebook {get; set;}
        public SocialsModel? Twitter {get; set;}
        public SocialsModel? Instagram {get; set;}
        public SocialsModel? Youtube {get; set;}
    }
}