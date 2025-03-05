using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialDashBackEnd.Models;
using SocialDashBackEnd.Services;

namespace SocialDashBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SocialsController : ControllerBase
    {
        private readonly SocialsServices _socialsServices;
        public SocialsController (SocialsServices socialsServices)
        {
            _socialsServices = socialsServices;
        }

        [HttpGet]
        [Route("GetData")]

        public List<Platforms> GetData()
        {
            return _socialsServices.GetData();
        }
    }
}