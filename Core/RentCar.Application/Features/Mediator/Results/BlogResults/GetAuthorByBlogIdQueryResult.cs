﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Results.BlogResults
{
    public class GetAuthorByBlogIdQueryResult
    {
        public int BlogID { get; set; }
        public int AuthorID { get; set; }
        public string? AuthorName { get; set; }
        public string? AuthorImageURL { get; set; }
        public string? AuthorDescription { get; set; }
    }
}
