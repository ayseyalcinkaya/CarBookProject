﻿using CarBook.Application.Feautures.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Feautures.Mediator.Queries.BlogQueries
{
    public class GetBlogQuery:IRequest<List<GetBlogQueryResult>>
    {
    }
}
