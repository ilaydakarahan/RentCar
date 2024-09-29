using Microsoft.EntityFrameworkCore;
using RentCar.Application.Features.Mediator.Results.CarPricingResults;
using RentCar.Application.Interfaces.CarPricingInterfaces;
using RentCar.Domain.Entities;
using RentCar.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Repositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly RentCarContext _context;

        public CarPricingRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task<List<CarPricing>> GetCarPricingWithCars()     
        {
            var values = await _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(z => z.PricingId == 2).ToListAsync();
            return values;
        }

        public async Task<List<GetCarPricingWithTimePeriodQueryResult>> GetCarPricingWithTimePeriod()
        {
            var carPricings =await _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand)
           .GroupBy(x => new { x.CarId, x.Car.Model, x.Car.Brand.Name, x.Car.CoverImageUrl }) 
           .Select(g => new GetCarPricingWithTimePeriodQueryResult
           {
               CarId = g.Key.CarId,
               Model = g.Key.Model,
               BrandName = g.Key.Name,
               CoverPhoto = g.Key.CoverImageUrl,
               DailyAmount = g.Where(x => x.PricingId == 2).Sum(y => y.Amount),
               WeeklyAmount = g.Where(x => x.PricingId == 4).Sum(y => y.Amount),
               MonthlyAmount = g.Where(x => x.PricingId == 5).Sum(y => y.Amount)
           }).ToListAsync();

            return carPricings;
        }
    }
}
