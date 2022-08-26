using System.Security.Claims;
using Defender.ServiceTemplate.Application.Common.Interfaces;
using Defender.ServiceTemplate.Domain.Entities.User;

namespace Defender.ServiceTemplate.WebUI.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public User? User
    {
        get
        {
            var currentUserClaims = _httpContextAccessor.HttpContext?.User.Claims;

            var user = new User();

            if (Guid.TryParse(
                currentUserClaims
                    .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value,
                out var guid))
            {
                user.Id = guid;
            }

            user.Name = currentUserClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

            user.Email = currentUserClaims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;

            user.Roles = currentUserClaims
                .Where(x => x.Type == ClaimTypes.Role)
                .Select(x => x.Value)
                .ToList();

            return user;
        }
    }

    public string Token
    {
        get
        {
            return _httpContextAccessor.HttpContext?.Request.Headers.Authorization;
        }
    }
}
