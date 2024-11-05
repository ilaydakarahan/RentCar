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
    public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand>
    {
        private readonly IRepository<Review> _repository;

        public UpdateReviewCommandHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }
        public async Task Handle ( UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ReviewId);
            values.ReviewDate = DateTime.Now;
            values.StarValue = request.StarValue;
            values.Image = request.Image;
            values.CustomerName = request.CustomerName;
            values.CarId = request.CarId;
            values.Comment = request.Comment;
            await _repository.UpdateAsync(values);
        }
    }
}
