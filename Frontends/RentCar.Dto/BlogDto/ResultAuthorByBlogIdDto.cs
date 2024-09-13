using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Dto.BlogDto
{
    public class ResultAuthorByBlogIdDto
    {
        public int BlogID { get; set; }
        public int AuthorID { get; set; }
        public string? AuthorName { get; set; }
        public string? AuthorImageURL { get; set; }
        public string? AuthorDescription { get; set; }
    }
}
