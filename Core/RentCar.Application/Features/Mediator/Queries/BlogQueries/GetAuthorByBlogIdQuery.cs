using MediatR;
using RentCar.Application.Features.Mediator.Results.BlogResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetAuthorByBlogIdQuery : IRequest<GetAuthorByBlogIdQueryResult>
    {
        public int Id { get; set; }

        public GetAuthorByBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}
