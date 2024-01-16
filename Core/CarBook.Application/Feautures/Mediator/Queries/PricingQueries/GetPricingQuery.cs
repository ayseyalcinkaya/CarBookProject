using CarBook.Application.Feautures.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Queries.PricingQueries
{
    public class GetPricingQuery: IRequest<List<GetPricingQueryResult>>
    {
    }
}
