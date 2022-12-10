using Rentel.ServiceTemplate.Application.Common.Interfaces;
using Rentel.ServiceTemplate.Application.Helpers;
using FluentValidation;
using MediatR;
using Rentel.ServiceTemplate.Application.Common.Models.LoginResponse;

namespace Rentel.ServiceTemplate.Application.Modules.Auth.Commands;

public record LoginGoogleCommand : IRequest<LoginResponse>
{
    public string? Token { get; set; }
};

public sealed class LoginGoogleCommandValidator :
    AbstractValidator<LoginGoogleCommand>
{
    public LoginGoogleCommandValidator()
    {
        RuleFor(x => x.Token).NotEmpty().WithMessage("No token!");
    }
}

public sealed class LoginGoogleCommandHandler :
    IRequestHandler<LoginGoogleCommand, LoginResponse>
{
    private readonly IAuthService _authService;

    public LoginGoogleCommandHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<LoginResponse> Handle(
        LoginGoogleCommand request,
        CancellationToken cancellationToken)
    {
        var response = new LoginResponse();

        try
        {
            response = await _authService.Authenticate(request.Token);
        }
        catch (Exception ex)
        {
            response.Authorized = false;
            response.UserDetails = null;
            response.Token = String.Empty;

            SimpleLogger.Log(ex);
        }

        return response;
    }
}
