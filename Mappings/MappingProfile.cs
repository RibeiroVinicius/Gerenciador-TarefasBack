using AutoMapper;
using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Tarefa, TarefaDTO>().ReverseMap();
            CreateMap<CreateTarefaDTO, Tarefa>();
            CreateMap<UpdateTarefaDTO, Tarefa>();
        }
    }
}
