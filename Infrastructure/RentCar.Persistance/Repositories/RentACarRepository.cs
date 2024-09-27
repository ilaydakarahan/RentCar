using Microsoft.EntityFrameworkCore;
using RentCar.Application.Interfaces.RentACarInterfaces;
using RentCar.Domain.Entities;
using RentCar.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Repositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly RentCarContext _context;

        public RentACarRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            return await _context.RentACars.Where(filter).Include(t => t.Car).ThenInclude(z => z.Brand).ToListAsync();
        }
    }
}
