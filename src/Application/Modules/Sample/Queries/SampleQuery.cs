using Rentel.ServiceTemplate.Application.Common.Interfaces;
using FluentValidation;
using MediatR;

namespace Rentel.ServiceTemplate.Application.Modules.Sample.Queries;

public record SampleQuery : IRequest
{
    public Guid Id { get; set; }
};

public sealed class SampleQueryValidator : AbstractValidator<SampleQuery>
{
    public SampleQueryValidator()
    {
        RuleFor(x => x.Id).NotNull().WithMessage("No id!");
    }
}

public sealed class SampleQueryHandler : IRequestHandler<SampleQuery>
{
    private readonly ISampleService _sampleService;

    public SampleQueryHandler(
        ISampleService sampleService)
    {
        _sampleService = sampleService;
    }

    public async Task<Unit> Handle(SampleQuery request, CancellationToken cancellationToken)
    {
        await _sampleService.GetSampleAsync();

        return Unit.Value;
    }
}
