﻿using CarBook.Application.Feautures.CQRS.Results.CategoryResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Feautures.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryID = x.CategoryID,
                Name = x.Name,
            }).ToList();
        }
    }
}
