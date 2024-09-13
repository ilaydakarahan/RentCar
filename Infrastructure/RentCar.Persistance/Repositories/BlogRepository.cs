using Microsoft.EntityFrameworkCore;
using RentCar.Application.Interfaces.BlogInterfaces;
using RentCar.Domain.Entities;
using RentCar.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly RentCarContext _context;

        public BlogRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task<List<Blog>> GetAllBlogsWithAuthors()
        {
            var values = await _context.Blogs.Include(x=>x.Author).ToListAsync();
            return values;
        }

        public async Task<Blog> GetAuthorByBlogId(int id)
        {
            var values = await _context.Blogs.Include(x => x.Author).Where(x => x.BlogId == id).FirstOrDefaultAsync();
            if (values == null)
            {
                throw new Exception("İlgili bloga ait yazar bulunamadı");
            }
            return values;
        }

        public async Task<List<Blog>> GetLast3BlogsWithAutorsAsync()
        {
            var values = await _context.Blogs.Include(x=>x.Author).OrderByDescending(x=>x.BlogId).Take(3).ToListAsync();
            return values;
        }
    }
}
