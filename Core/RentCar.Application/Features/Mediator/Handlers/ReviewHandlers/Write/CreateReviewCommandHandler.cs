using MediatR;
using RentCar.Application.Features.Mediator.Commands.ReviewCommands;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.ReviewHandlers.Write
{
    public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand>
    {
        private readonly IRepository<Review> _repository;

        public CreateReviewCommandHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task Handle (CreateReviewCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Review
            {
                CarId = request.CarId,
                ReviewDate = DateTime.Now,
                CustomerName = request.CustomerName,
                Comment = request.Comment,
                StarValue = request.StarValue,
                Image = request.Image
            });
        }
    }
}
