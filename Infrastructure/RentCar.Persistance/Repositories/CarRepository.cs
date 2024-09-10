using Microsoft.EntityFrameworkCore;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using RentCar.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly RentCarContext _context;

        public CarRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetCarsListWithBrandsAsync()
        {
            var values = await _context.Cars.Include(x=>x.Brand).ToListAsync();
            return values;
        }

        public async Task<List<Car>> GetLast5CarsWithBrands()
        {
            var values = await _context.Cars.Include(x=>x.Brand).OrderByDescending(y=>y.CarId).Take(5).ToListAsync();
            return values;
        }
    }
}
