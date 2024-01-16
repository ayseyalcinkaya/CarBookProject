using MediatR;

namespace CarBook.Application.Feautures.Mediator.Commands.LocationCommands
{
    public class CreateLocationCommand:IRequest
    {
        public string Name { get; set; }
    }
}
