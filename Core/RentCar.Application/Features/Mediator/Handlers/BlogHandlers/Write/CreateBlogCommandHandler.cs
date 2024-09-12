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
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog
            {
                Description = request.Description,
                BlogCategoryId = request.BlogCategoryId,
                CoverImageURL = request.CoverImageURL,
                AuthorId = request.AuthorId,
                CreatedDate = request.CreatedDate,
                Title = request.Title
            });
        }
    }
}
