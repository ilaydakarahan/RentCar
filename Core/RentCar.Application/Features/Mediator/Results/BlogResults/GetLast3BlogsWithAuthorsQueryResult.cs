using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Results.BlogResults
{
    public class GetLast3BlogsWithAuthorsQueryResult
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string CoverImageURL { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogCategoryId { get; set; }
        public string AuthorName { get; set; }  //Yeni result oluşturduktan sonra, repositoryde özel metod yazınca buraya name ekleniyor.
        public string Description { get; set; }
    }
}
