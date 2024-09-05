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
    public class RemoveBlogCategoryCommandHandler
    {
        private readonly IRepository<BlogCategory> _repository;

        public RemoveBlogCategoryCommandHandler(IRepository<BlogCategory> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveBlogCategoryCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
