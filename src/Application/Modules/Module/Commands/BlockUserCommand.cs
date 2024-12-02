using Defender.Common.Errors;
using Defender.Common.Extension;
using Defender.Common.Interfaces;
using Defender.ServiceTemplate.Application.Common.Interfaces.Services;
using FluentValidation;
using MediatR;

namespace Defender.ServiceTemplate.Application.Modules.Module.Commands;

public record ModuleCommand : IRequest<Unit>
{
    public bool DoModule { get; set; } = true;
};

public sealed class ModuleCommandValidator : AbstractValidator<ModuleCommand>
{
    public ModuleCommandValidator()
    {
        RuleFor(s => s.DoModule)
            .NotEmpty()
            .WithMessage(ErrorCode.VL_InvalidRequest);
    }
}

public sealed class ModuleCommandHandler(
        IAccountAccessor accountAccessor,
        IService accountManagementService)
    : IRequestHandler<ModuleCommand, Unit>
{
    public async Task<Unit> Handle(ModuleCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
