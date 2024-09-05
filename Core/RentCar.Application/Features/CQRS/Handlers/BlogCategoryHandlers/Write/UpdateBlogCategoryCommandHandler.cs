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
    public class UpdateBlogCategoryCommandHandler
    {
        private readonly IRepository<BlogCategory> _blogCategoryRepository;

        public UpdateBlogCategoryCommandHandler(IRepository<BlogCategory> blogCategoryRepository)
        {
            _blogCategoryRepository = blogCategoryRepository;
        }
        public async Task Handle(UpdateBlogCategoryCommand blogCategoryCommand)
        {
            var values = await _blogCategoryRepository.GetByIdAsync(blogCategoryCommand.BlogCategoryId);
            values.BlogCategoryName = blogCategoryCommand.BlogCategoryName;
            await _blogCategoryRepository.UpdateAsync(values);
        }
    }
}
