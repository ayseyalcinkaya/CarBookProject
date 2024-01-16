using CarBook.Application.Feautures.Mediator.Results.LocationResults;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery:IRequest<List<GetLocationQueryResult>>
    {
    }
}
