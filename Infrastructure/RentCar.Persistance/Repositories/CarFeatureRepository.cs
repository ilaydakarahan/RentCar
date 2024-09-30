using Microsoft.EntityFrameworkCore;
using RentCar.Application.Interfaces.ICarFeatureInterfaces;
using RentCar.Domain.Entities;
using RentCar.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Repositories
{
    public class CarFeatureRepository : ICarFeatureRepository
    {
        private readonly RentCarContext _context;

        public CarFeatureRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task ChangeCarFeatureAvailableToFalse(int id)
        {
            var value = await _context.CarFeatures.Where(t => t.CarFeatureId == id).FirstOrDefaultAsync();
            value.Available = false;
            await _context.SaveChangesAsync();
        }

        public async Task ChangeCarFeatureAvailableToTrue(int id)
        {
            var value = await _context.CarFeatures.Where(t => t.CarFeatureId == id).FirstOrDefaultAsync();
            value.Available = true;
            await _context.SaveChangesAsync();
        }

        public async Task CreateCarFeatureByCar(CarFeature carFeature)
        {
            var values = await _context.CarFeatures.Where(t => t.CarId == carFeature.CarId && t.FeatureId == carFeature.FeatureId).ToListAsync();
            if (values.Count == 0)
            {
                _context.CarFeatures.Add(carFeature);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<CarFeature>> GetCarFeatureByCarId(int id)
        {
            return _context.CarFeatures.Where(x=>x.CarId == id).Include(t=>t.Car).Include(x => x.Feature).ToListAsync();
        }
    }
}
