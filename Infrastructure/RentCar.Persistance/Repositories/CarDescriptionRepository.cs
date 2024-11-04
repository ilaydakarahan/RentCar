using Microsoft.EntityFrameworkCore;
using RentCar.Application.Interfaces.CarDescriptionInterfaces;
using RentCar.Domain.Entities;
using RentCar.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Repositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly RentCarContext _context;

        public CarDescriptionRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task<CarDescription> GetCarDescription(int carId)
        {
            return await _context.CarDescriptions.Where(x => x.CarId == carId).FirstOrDefaultAsync();
        }
    }
}
