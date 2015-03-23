using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ViewModelToModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ViewModel.AgendaViewModel, Model.Agenda>();
        }
    }
}
