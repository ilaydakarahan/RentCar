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
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _blogrepository;
        public GetAllBlogsWithAuthorQueryHandler(IBlogRepository blogrepository)
        {
            _blogrepository = blogrepository;
        }

        public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _blogrepository.GetAllBlogsWithAuthors();
            return values.Select(x => new GetAllBlogsWithAuthorQueryResult
            {
                AuthorName = x.Author.Name,
                BlogCategoryId = x.BlogCategoryId,
                CoverImageURL = x.CoverImageURL,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                Description = x.Description,
                BlogId = x.BlogId,
                AuthorId = x.AuthorId          
            }).ToList();
        }
    }
}
