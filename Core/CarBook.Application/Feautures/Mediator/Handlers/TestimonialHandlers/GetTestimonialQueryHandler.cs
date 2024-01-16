﻿using CarBook.Application.Feautures.Mediator.Queries.TestimonialQueries;
using CarBook.Application.Feautures.Mediator.Results.TestimonialResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Feautures.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {

                TestimonialID = x.TestimonialID,
                Comment = x.Comment,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Title = x.Title,

            }).ToList();

        }
    }
}
