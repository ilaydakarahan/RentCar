using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Commands.BlogCategoryCommands
{
    public class CreateBlogCategoryCommand
    {
        public string BlogCategoryName { get; set; }
    }
}
