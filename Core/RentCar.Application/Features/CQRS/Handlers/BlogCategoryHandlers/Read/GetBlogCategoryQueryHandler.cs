using RentCar.Application.Features.CQRS.Results.CategoryResults;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Handlers.BlogCategoryHandlers.Read
{
    public class GetBlogCategoryQueryHandler
    {
        private readonly IRepository<BlogCategory> _blogCategoryRepository;

        public GetBlogCategoryQueryHandler(IRepository<BlogCategory> blogCategoryRepository)
        {
            _blogCategoryRepository = blogCategoryRepository;
        }

        public async Task<List<GetBlogCategoryQueryResult>> Handle()
        {
            var values = await _blogCategoryRepository.GetAllAsync();
            return values.Select(x=> new GetBlogCategoryQueryResult
            {
                BlogCategoryId = x.BlogCategoryId,
                BlogCategoryName = x.BlogCategoryName
            }).ToList();
        }
    }
}
