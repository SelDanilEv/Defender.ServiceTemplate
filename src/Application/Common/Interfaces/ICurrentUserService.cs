using Defender.ServiceTemplate.Domain.Entities.User;

namespace Defender.ServiceTemplate.Application.Common.Interfaces;

public interface ICurrentUserService
{
    User? User { get; }
    string Token { get; }
}
