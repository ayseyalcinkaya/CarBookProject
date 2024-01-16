using MediatR;

namespace CarBook.Application.Feautures.Mediator.Commands.LocationCommands
{
    public class UpdateLocationCommand:IRequest
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
    }
}
