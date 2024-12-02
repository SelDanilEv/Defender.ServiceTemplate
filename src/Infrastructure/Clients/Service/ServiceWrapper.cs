using AutoMapper;
using Defender.Common.Clients.Identity;
using Defender.Common.Wrapper;
using Defender.ServiceTemplate.Application.Common.Interfaces.Wrapper;

namespace Defender.ServiceTemplate.Infrastructure.Clients.Service;

public class ServiceWrapper(
        IIdentityServiceClient service,
        IMapper mapper)
    : BaseSwaggerWrapper, IServiceWrapper
{
    public Task DoWrap()
    {
        //var createCommand = new CreateUserCommand()
        //{
        //    Email = user.Email,
        //    PhoneNumber = user.PhoneNumber,
        //    Nickname = user.Nickname
        //};

        //return await ExecuteSafelyAsync(async () =>
        //{
        //    var response = await _userManagementClient.CreateAsync(createCommand);

        //    return _mapper.Map<Common.DTOs.UserDto>(response);
        //});
        throw new NotImplementedException();
    }
}
