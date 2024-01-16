using CarBook.Application.Feautures.Mediator.Results.SocialMediaResults;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery: IRequest <GetSocialMediaByIdQueryResult>
    {
        public int Id { get; set; }

        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }
    }
}
