using RentCar.Application.Features.CQRS.Queries.BlogCategoryQueries;
using RentCar.Application.Features.CQRS.Results.BlogCategoryResults;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Handlers.BlogCategoryHandlers.Read
{
    public class GetBlogCategoryByIdQueryHandler
    {
        private readonly IRepository<BlogCategory> _blogCategoryRepository;

        public GetBlogCategoryByIdQueryHandler(IRepository<BlogCategory> blogCategoryRepository)
        {
            _blogCategoryRepository = blogCategoryRepository;
        }

        public async Task<GetBlogCategoryByIdQueryResult> Handle(GetBlogCategoryByIdQuery query)
        {
            var value = await _blogCategoryRepository.GetByIdAsync(query.Id);
            return new GetBlogCategoryByIdQueryResult
            {
                BlogCategoryId = value.BlogCategoryId,
                BlogCategoryName = value.BlogCategoryName
            };
        }
    }
}
