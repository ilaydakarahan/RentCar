using MediatR;
using RentCar.Application.Features.Mediator.Queries.BlogQueries;
using RentCar.Application.Features.Mediator.Results.BlogResults;
using RentCar.Application.Interfaces.BlogInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.BlogHandlers.Read
{
    public class GetLast3BlogsWithAutorsQueryHandler : IRequestHandler<GetLast3BlogWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetLast3BlogsWithAutorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetLast3BlogsWithAutorsAsync();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
            {
                BlogId = x.BlogId,
                AuthorId = x.AuthorId,
                Description = x.Description,
                AuthorName = x.Author.Name,
                BlogCategoryId = x.BlogCategoryId,
                CoverImageURL = x.CoverImageURL,
                CreatedDate = x.CreatedDate,
                Title = x.Title

            }).ToList();
        }
    }
}
