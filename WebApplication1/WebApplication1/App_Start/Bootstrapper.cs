using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialGoal.Mappings;

namespace WebApplication1.App_Start
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            //Configure AutoMapper
            AutoMapperConfiguration.Configure();
        }
    }
}