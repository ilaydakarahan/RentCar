using MediatR;
using RentCar.Application.Features.Mediator.Queries.BlogQueries;
using RentCar.Application.Features.Mediator.Results.BlogResults;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.BlogHandlers.Read
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x => new GetBlogQueryResult
            {
                BlogId = x.BlogId,
                Description = x.Description,
                Title = x.Title,
                CoverImageURL = x.CoverImageURL,
                BlogCategoryId = x.BlogCategoryId,
                CreatedDate = x.CreatedDate,
                AuthorId = x.AuthorId
            }).ToList();
        }
    }
}
