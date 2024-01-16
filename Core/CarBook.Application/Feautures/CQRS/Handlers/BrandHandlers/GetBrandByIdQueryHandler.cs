using CarBook.Application.Feautures.CQRS.Queries.BannerQueries;
using CarBook.Application.Feautures.CQRS.Queries.BrandQueries;
using CarBook.Application.Feautures.CQRS.Results.BannerResult;
using CarBook.Application.Feautures.CQRS.Results.BrandResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Feautures.CQRS.Handlers.BrandHandlers
{

    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
                BrandID = values.BrandID,
                Name = values.Name,

            };
        }
    }
}
