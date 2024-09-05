using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Commands.BlogCategoryCommands
{
    public class UpdateBlogCategoryCommand
    {
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }
    }
}
