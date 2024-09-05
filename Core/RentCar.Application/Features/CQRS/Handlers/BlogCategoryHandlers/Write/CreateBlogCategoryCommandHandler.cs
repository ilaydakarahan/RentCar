using RentCar.Application.Features.CQRS.Commands.BlogCategoryCommands;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Handlers.BlogCategoryHandlers.Write
{
    public class CreateBlogCategoryCommandHandler
    {
        private readonly IRepository<BlogCategory> _repsitory;

        public CreateBlogCategoryCommandHandler(IRepository<BlogCategory> repsitory)
        {
            _repsitory = repsitory;
        }

        public async Task Handle(CreateBlogCategoryCommand createCategory)
        {
            await _repsitory.CreateAsync(new BlogCategory
            {
                BlogCategoryName = createCategory.BlogCategoryName
            });
        }
    }
}
