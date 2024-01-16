using CarBook.Application.Feautures.Mediator.Results.LocationResults;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Queries.LocationQueries
{
    public class GetLocationByIdQuery:IRequest<GetLocationByIdQueryResult>
    {
        public int Id { get; set; }

        public GetLocationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
