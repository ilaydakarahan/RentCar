using RentCar.Application.Features.Mediator.Results.CarPricingResults;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        Task<List<CarPricing>> GetCarPricingWithCars();
        Task<List<GetCarPricingWithTimePeriodQueryResult>> GetCarPricingWithTimePeriod();
    }
}
