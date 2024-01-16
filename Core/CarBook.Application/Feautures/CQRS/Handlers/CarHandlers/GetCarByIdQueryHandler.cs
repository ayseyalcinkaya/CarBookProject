using CarBook.Application.Feautures.CQRS.Queries.CarQueries;
using CarBook.Application.Feautures.CQRS.Results.CarResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Feautures.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandID = values.BrandID,
                BigImageUrl = values.BigImageUrl,
                CoverImageURL = values.CoverImageURL,
                Fuel = values.Fuel,
                CarID = values.CarID,
                Transmission = values.Transmission,
                Seat = values.Seat,
                Model = values.Model,
                Luggage = values.Luggage,
                Km = values.Km

            };
        }
    }
}
