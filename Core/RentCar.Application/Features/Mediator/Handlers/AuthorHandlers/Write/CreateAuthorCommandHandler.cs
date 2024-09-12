using MediatR;
using RentCar.Application.Features.Mediator.Commands.AuthorCommands;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.AuthorHandlers.Write
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public CreateBlogCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Author
            {
                Description = request.Description,
                ImageURL = request.ImageURL,
                Name = request.Name,
            });
        }
    }
}
