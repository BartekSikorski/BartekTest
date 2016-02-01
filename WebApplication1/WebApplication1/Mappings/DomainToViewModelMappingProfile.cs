using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace SocialGoal.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Person, PersonVM>().
                ForMember(dest => dest.FirsName,
                          opt => opt.MapFrom(src => src.FirstName)).
                ForMember(dest => dest.Surname,
                           opt => opt.MapFrom(src => src.Surname)).
                ForMember(dest => dest.Birthdate,
                           opt => opt.MapFrom(src => src.Birthdate));
            Mapper.CreateMap<Address, AddressVM>();
               
         
        }
    }
}