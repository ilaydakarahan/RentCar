using MediatR;
using RentCar.Application.Features.Mediator.Commands.BlogCommands;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.BlogHandlers.Write
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BlogId);
            value.CoverImageURL = request.CoverImageURL;
            value.Description = request.Description;
            value.AuthorId = request.AuthorId;
            value.BlogCategoryId = request.BlogCategoryId;
            value.Title = request.Title;
            value.CreatedDate = request.CreatedDate;
            await _repository.UpdateAsync(value);
        }
    }
}
