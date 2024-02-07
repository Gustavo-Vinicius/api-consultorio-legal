using AutoMapper;
using Consultorio_Legal.CORE.Domain;
using Consultorio_Legal.CORE.SHARED.ModelViews;

namespace Consultorio_Legal.MANAGER.Mappings
{
    public class NovoClienteMappingProfile : Profile
    {
        public NovoClienteMappingProfile()
        {
            CreateMap<NovoCliente, Cliente>()
            .ForMember(d => d.Criacao, o => o.MapFrom(x => DateTime.Now))
            .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));

            CreateMap<NovoEndereco, Enderecos>();
            CreateMap<NovoTelefone, Telefone>();

        }
    }
}