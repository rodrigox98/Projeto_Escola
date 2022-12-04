using AutoMapper;
using EscolaAPIdotnet5.DTO.AlunoDTO;
using EscolaAPIdotnet5.Models;

namespace EscolaAPIdotnet5.Profiles
{
    public class AlunoProfile : Profile
    {
        public AlunoProfile()
        {
            CreateMap<CreateAlunoDTO, Aluno>();
            CreateMap<Aluno, ReadAlunoDTO>();
        }
    }
}
