﻿using CarBook.Application.Feautures.Mediator.Commands.AuthorCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Handlers.AuthorHandlers
{
    public class UpdateAuthorCommandHandler:IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public UpdateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AuthorID);

            values.Name = request.Name;
            values.Description = request.Description;
            values.ImageUrl = request.ImageUrl;

            await _repository.UpdateAsync(values);
        }
    
    }
}
