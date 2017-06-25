using AutoMapper;
using CSharp.Model;
using CSharp.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharp.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
           Mapper.Initialize(m =>
           {
               m.CreateMap<Award, AwardViewModel>();
               m.CreateMap<Grant, GrantViewModel>();
           });           
        }
    }
}