using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public Task<List<Blog>> GetLast3BlogsWithAutorsAsync();
        public Task<List<Blog>> GetAllBlogsWithAuthors();
        public Task<Blog> GetAuthorByBlogId(int id);

    }
}
