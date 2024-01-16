using CarBook.Application.Feautures.Mediator.Results.ServiceResults;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
    {
        public int Id { get; set; }

        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}
