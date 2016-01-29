using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WebApplication1.Models;

namespace WebApplication1.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PersonProfile());
            });

            var mapper = config.CreateMapper();

            //Mapper.Initialize(cfg =>
            //{
            //    cfg.AddProfile(new PersonProfile());
            //}
            //);

        }

    }

    public class PersonProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Person,PersonVM>();
        }
    }
}