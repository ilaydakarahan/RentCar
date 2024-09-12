using MediatR;
using RentCar.Application.Features.Mediator.Queries.CarPricingQueries;
using RentCar.Application.Features.Mediator.Results.CarPricingResults;
using RentCar.Application.Interfaces;
using RentCar.Application.Interfaces.CarPricingInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPricingWithCarQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values = await _carPricingRepository.GetCarPricingWithCars();
            return values.Select(x => new GetCarPricingWithCarQueryResult
            {
                Amount = x.Amount,
                CoverImageUrl = x.Car.CoverImageUrl,
                Model = x.Car.Model,
                Brand = x.Car.Brand.Name,
                CarId = x.CarId,
                CarPricingId = x.CarPricingId
            }).ToList();
        }
    }
}
