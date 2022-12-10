using Microsoft.AspNetCore.Authorization;

namespace Rentel.ServiceTemplate.WebUI.Attributes;

public class AuthAttribute : AuthorizeAttribute
{
    public AuthAttribute(params string[] roles)
    {
        Roles = String.Join(",", roles);
    }
}

