using CQRS.Application.Abstractions;

namespace CQRS.Application.Queries
{
    public sealed record GetUserByIdQuery(Guid UserId) : IQuery<string>;
}