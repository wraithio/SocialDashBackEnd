using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialDashBackEnd.Models;

namespace SocialDashBackEnd.Services
{
    public class SocialsServices
    {
        public List<Platforms> SocialData = new();
        public List<SocialsModel> Facebook = new();
        public SocialsServices()
        {
            SocialData.Add(
                new Platforms
                {
                    Facebook = new SocialsModel
                    {
                        name = "@nathanf",
                        followers = "1987",
                        followerchange = 12,
                        views = "87",
                        viewschange = 3,
                        likes = 52,
                        likeschange = -2,
                        icon = "./images/icon-facebook.svg",
                    },
                    Twitter = new SocialsModel
                    {
                        name = "@nathanf",
                        followers = "1044",
                        followerchange = 99,
                        views = "117",
                        viewschange = 303,
                        likes = 507,
                        likeschange = 553,
                        icon = "./images/icon-twitter.svg",
                    },
                    Instagram = new SocialsModel
                    {
                        name = "@realnathanf",
                        followers = "11k",
                        followerchange = 1099,
                        views = "52k",
                        viewschange = 1375,
                        likes = 5462,
                        likeschange = 2257,
                        icon = "./images/icon-instagram.svg",
                    },
                    Youtube = new SocialsModel
                    {
                        name = "Nathan F.",
                        followers = "8239",
                        followerchange = -114,
                        views = "1407",
                        viewschange = -12,
                        likes = 107,
                        likeschange = -19,
                        icon = "./images/icon-youtube.svg",
                    }
                });

            // fbtest.Add(
            //     new FB
            //     {
            //         Facebook = new SocialsModel
            //         {
            //             name = "@nathanf",
            //             followers = "1987",
            //             followerchange = 12,
            //             views = "87",
            //             viewschange = 3,
            //             likes = 52,
            //             likeschange = -2,
            //             icon = "./images/icon-facebook.svg",
            //         }
            //     }
            // );
        }

        public List<Platforms> GetData()
        {
            return SocialData;
        }
    }
}