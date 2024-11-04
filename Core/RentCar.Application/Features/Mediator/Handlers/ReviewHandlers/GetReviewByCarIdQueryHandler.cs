using MediatR;
using RentCar.Application.Features.Mediator.Queries.ReviewQueries;
using RentCar.Application.Features.Mediator.Results.ReviewResults;
using RentCar.Application.Interfaces.ReviewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class GetReviewByCarIdQueryHandler : IRequestHandler<GetReviewByCarIdQuery, List<GetReviewByCarIdQueryResult>>
    {
        private readonly IReviewRepository _reviewRepository;

        public GetReviewByCarIdQueryHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<List<GetReviewByCarIdQueryResult>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _reviewRepository.GetReviewListByCarId(request.Id);
            return values.Select(t => new GetReviewByCarIdQueryResult
            {
                CarId = t.CarId,
                Comment = t.Comment,
                CustomerName = t.CustomerName,
                Image = t.Image,
                StarValue = t.StarValue,
                ReviewDate = t.ReviewDate,
                ReviewId = t.ReviewId
            }).ToList();
        }
    }
}
