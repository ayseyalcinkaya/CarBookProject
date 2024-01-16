using CarBook.Application.Feautures.Mediator.Results.ServiceResults;
using CarBook.Application.Feautures.Mediator.Results.SocialMediaResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Feautures.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery: IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}
