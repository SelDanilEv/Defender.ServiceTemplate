using AutoMapper;
using Rentel.ServiceTemplate.Application.Common.Models.LoginResponse;

namespace Rentel.ServiceTemplate.Infrastructure.Mappings;

public class ClientModelsProfile : Profile
{
    public ClientModelsProfile()
    {
        CreateMap<
            Clients.UserManagement.LoginResponse,
            LoginResponse>();

        CreateMap<
            Clients.UserManagement.UserDto,
            Application.DTOs.UserDto>();
    }
}
