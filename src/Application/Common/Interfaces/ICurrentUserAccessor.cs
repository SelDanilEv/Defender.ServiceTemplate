using Rentel.ServiceTemplate.Domain.Entities.User;

namespace Rentel.ServiceTemplate.Application.Common.Interfaces;

public interface ICurrentUserAccessor
{
    User? User { get; }
    string Token { get; }
}
