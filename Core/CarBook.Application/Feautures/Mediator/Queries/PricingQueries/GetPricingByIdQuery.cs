using CarBook.Application.Feautures.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
