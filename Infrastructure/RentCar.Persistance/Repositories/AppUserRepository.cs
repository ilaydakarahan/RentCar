using Microsoft.EntityFrameworkCore;
using RentCar.Application.Interfaces.AppUserInterfaces;
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
    public class AppUserRepository : IAppUserRepository
    {
        private readonly RentCarContext _context;

        public AppUserRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task<AppUser> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            return await _context.AppUsers.Where(filter).FirstOrDefaultAsync();
        }
    }
}
