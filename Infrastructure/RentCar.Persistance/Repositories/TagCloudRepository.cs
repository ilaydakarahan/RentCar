using Microsoft.EntityFrameworkCore;
using RentCar.Application.Interfaces.TagCloudInterfaces;
using RentCar.Domain.Entities;
using RentCar.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Repositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly RentCarContext _context;

        public TagCloudRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task<List<TagCloud>> GetTagCloudByBlogIdAsync(int id)
        {
            var values = await _context.TagClouds.Where(x => x.BlogID == id).ToListAsync();
            return values;
        }
    }
}
