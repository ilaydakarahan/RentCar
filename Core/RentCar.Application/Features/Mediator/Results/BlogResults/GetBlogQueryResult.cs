using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogQueryResult
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string CoverImageURL { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogCategoryId { get; set; }

        public string Description { get; set; }
    }
}
