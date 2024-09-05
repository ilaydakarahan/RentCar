using RentCar.Application.Features.CQRS.Results.CarResults;
using RentCar.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Handlers.CarHandlers.Write
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetCarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<GetCarWithBrandQueryResult>> Handle()
        {
            var values = await _carRepository.GetCarsListWithBrandsAsync();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                CarId = x.CarId,
                BrandId = x.BrandId,
                BrandName = x.Brand.Name,
                BigImageUrl = x.BigImageUrl,
                Transmission = x.Transmission,
                Seat = x.Seat,
                Km = x.Km,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Luggage = x.Luggage,
                Model = x.Model
            }).ToList();
        }
    }
}
