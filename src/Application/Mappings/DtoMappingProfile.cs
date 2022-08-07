using AutoMapper;
using Defender.ServiceTemplate.Application.DTOs;
using Defender.ServiceTemplate.Domain.Entities.User;

namespace Defender.ServiceTemplate.Application.Common.Mappings;

public class DtoMappingProfile : Profile
{
    public DtoMappingProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.Value.ToShortDateString()));
    }
}
