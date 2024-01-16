using CarBook.Application.Feautures.Mediator.Queries.LocationQueries;
using CarBook.Application.Feautures.Mediator.Results.LocationResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Handlers.LocationHandlers
{
    public class GetLLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;

        public GetLLocationByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
           var values = await _repository.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                 LocationID = values.LocationID,
                  Name = values.Name,

            };
        }
    }
}
