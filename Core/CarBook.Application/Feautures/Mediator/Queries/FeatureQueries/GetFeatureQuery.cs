using CarBook.Application.Feautures.Mediator.Results.FeatureResults;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery:IRequest<List<GetFeatureQueryResult>>
    {
    }
}
