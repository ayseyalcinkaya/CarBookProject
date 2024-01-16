using CarBook.Application.Feautures.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CarBook.Application.Feautures.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressByIdQuery:IRequest<GetFooterAddressByIdQueryResult>
    {
        public int Id { get; set; }

        public GetFooterAddressByIdQuery(int id)
        {
            Id = id;
        }
    }
}
