using CQRS.Application.Abstractions;

namespace CQRS.Application.Commands
{
    public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        public Task Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}