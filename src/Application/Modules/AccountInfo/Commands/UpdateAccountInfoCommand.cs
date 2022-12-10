using Rentel.ServiceTemplate.Application.Common.Interfaces;
using Rentel.ServiceTemplate.Application.DTOs;
using FluentValidation;
using MediatR;

namespace Rentel.ServiceTemplate.Application.Modules.Auth.Commands;

public record UpdateAccountInfoCommand : IRequest<UserDto>
{
    public string? Name { get; set; }
    public string? Email { get; set; }
};

public sealed class UpdateAccountInfoCommandValidator :
    AbstractValidator<UpdateAccountInfoCommand>
{
    public UpdateAccountInfoCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("The name must be not empty!");
        RuleFor(x => x.Name).Length(3, 50).WithMessage("The name must be in range of 3-50 characters!");

        RuleFor(x => x.Email).NotEmpty().WithMessage("The email must be not empty!");
    }
}

public sealed class UpdateAccountInfoCommandHandler :
    IRequestHandler<UpdateAccountInfoCommand, UserDto>
{
    private readonly IAccountManagementService _accountManagement;

    public UpdateAccountInfoCommandHandler(IAccountManagementService accountManagement)
    {
        _accountManagement = accountManagement;
    }

    public async Task<UserDto> Handle(
        UpdateAccountInfoCommand request,
        CancellationToken cancellationToken)
    {
        return await _accountManagement.UpdateUserAsync(request);
    }
}
