using AutoMapper;
using PCBuilderMVC.Domain.Entities;
using PCBuilderMVC.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Service.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<PC, PCViewModel>();
        }
    }
}
