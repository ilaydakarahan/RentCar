using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Domain.Entities
{
    public class BlogCategory
    {
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }

        //public List<Blog> Blog { get; set; }
    }
}
