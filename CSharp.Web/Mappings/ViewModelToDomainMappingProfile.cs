using AutoMapper;
using CSharp.Model;
using CSharp.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharp.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            Mapper.Initialize(m =>
            {
                m.CreateMap<GrantFormViewModel, Grant>()
                  .ForMember(g => g.GrantAmount, map => map.MapFrom(vm => vm.Amount))
                  .ForMember(g => g.AgencyName, map => map.MapFrom(vm => vm.GrantedAgencyName))
                  .ForMember(g => g.AwardId, map => map.MapFrom(vm => vm.OriginalAwardId));
            });
        }
    }
}