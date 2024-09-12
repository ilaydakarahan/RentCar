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
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null)
            {
                return new GetBlogByIdQueryResult
                {
                    AuthorId = value.AuthorId,
                    BlogId = value.BlogId,
                    Description = value.Description,
                    CreatedDate = value.CreatedDate,
                    BlogCategoryId = value.BlogCategoryId,
                    CoverImageURL = value.CoverImageURL,
                    Title = value.Title,
                };
            }
            return new GetBlogByIdQueryResult();
        }
    }
}
