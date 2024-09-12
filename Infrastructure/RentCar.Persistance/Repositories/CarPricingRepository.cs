using Microsoft.EntityFrameworkCore;
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
            var values = await _context.CarPricings.Include(x => x.Car).ThenInclude(y=>y.Brand).Include(x=>x.Pricing).Where(z=>z.PricingId== 2).ToListAsync();
            return values;
        }
    }
}
