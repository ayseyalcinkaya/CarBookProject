﻿using MediatR;

namespace CarBook.Application.Feautures.Mediator.Commands.LocationCommands
{
    public class RemoveLocationCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveLocationCommand(int id)
        {
            Id = id;
        }
    }
}
