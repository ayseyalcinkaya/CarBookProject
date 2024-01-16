using CarBook.Application.Feautures.Mediator.Results.ServiceResults;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
    {
    }
}
