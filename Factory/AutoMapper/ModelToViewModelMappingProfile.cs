using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ModelToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Model.Agenda, ViewModel.AgendaViewModel>();
            //.ForMember(dest => dest.MedicoNome, opts => opts.MapFrom(src => src.Medico.Nome));

            //var model = AutoMapper.Mapper.Map<BookViewModel>(book);
        }
    }
}
