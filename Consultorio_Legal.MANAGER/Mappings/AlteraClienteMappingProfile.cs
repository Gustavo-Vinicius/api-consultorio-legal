using AutoMapper;
using Consultorio_Legal.CORE.Domain;
using Consultorio_Legal.CORE.SHARED.ModelViews;

namespace Consultorio_Legal.MANAGER.Mappings
{
    public class AlteraClienteMappingProfile: Profile
    {
        public AlteraClienteMappingProfile()
        {
            CreateMap<AlteraCliente, Cliente>()
            .ForMember(d => d.UltimaAtualizacao, o => o.MapFrom(x => DateTime.Now))
            .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));
        }
    }
}