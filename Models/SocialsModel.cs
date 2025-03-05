using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialDashBackEnd.Models
{
    
    public class SocialsModel
    {
            public string? name {get;set;}
            public string? followers {get;set;}
            public int followerchange {get;set;}
            public string? views {get;set;}
            public int viewschange {get;set;}
            public int likes {get;set;}
            public int likeschange {get;set;}
            public string? icon {get;set;}
        
    }
}