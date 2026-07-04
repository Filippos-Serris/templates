using CQRS.Application.Abstractions;

namespace CQRS.Application.Commands
{
    public sealed record CreateUserCommand(string Name) : ICommand
    {

    }
}