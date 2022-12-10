using AutoMapper;
using Rentel.ServiceTemplate.Application.DTOs;
using Rentel.ServiceTemplate.Domain.Entities.User;

namespace Rentel.ServiceTemplate.Application.Common.Mappings;

public class DtoMappingProfile : Profile
{
    public DtoMappingProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(
            dest => dest.CreatedDate,
            opt => opt.MapFrom(
                src => src.CreatedDate.Value.ToShortDateString()));
    }
}
