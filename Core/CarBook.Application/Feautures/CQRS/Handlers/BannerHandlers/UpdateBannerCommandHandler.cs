using CarBook.Application.Feautures.CQRS.Commands.AboutCommands;
using CarBook.Application.Feautures.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Feautures.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerID);
            values.Title = command.Title;
            values.Description = command.Description;
            values.VideoUrl = command.VideoUrl;
            values.VideoDescription = command.VideoDescription;

            await _repository.UpdateAsync(values);
        }
    }
}
