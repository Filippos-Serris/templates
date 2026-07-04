using CQRS.Application.Abstractions;

namespace CQRS.Application.Queries
{
    public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, string>
    {
        public Task<string> Handle(GetUserByIdQuery query, CancellationToken cancellationToken)
        {
            return Task.FromResult(userName);
        }
    }
}