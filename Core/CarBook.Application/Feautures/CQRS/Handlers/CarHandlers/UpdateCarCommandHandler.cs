using CarBook.Application.Feautures.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Feautures.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {

        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);
            values.BigImageUrl = command.BigImageUrl;
            values.BrandID = command.BrandID;   
            values.Transmission=command.Transmission;
            values.Fuel=command.Fuel;
            values.CoverImageURL = command.CoverImageURL;
            values.Km=command.Km;
            values.Luggage=command.Luggage;
            values.Seat=command.Seat;
            values.Model=command.Model;

            await _repository.UpdateAsync(values);
        }
    }
}
