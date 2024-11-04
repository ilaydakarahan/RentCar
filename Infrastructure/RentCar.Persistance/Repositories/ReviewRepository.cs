using Microsoft.EntityFrameworkCore;
using RentCar.Application.Interfaces.ReviewInterfaces;
using RentCar.Domain.Entities;
using RentCar.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly RentCarContext _context;

        public ReviewRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task<List<Review>> GetReviewListByCarId(int carId)
        {
            return await _context.Reviews.Where(x => x.CarId == carId).ToListAsync();
        }
    }
}
