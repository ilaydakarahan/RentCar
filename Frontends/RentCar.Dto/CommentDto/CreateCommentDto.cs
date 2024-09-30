﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Dto.CommentDto
{
    public class CreateCommentDto
    {
        public string Name { get; set; }
        public string CommentContent { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogId { get; set; }
        public string Email { get; set; }

    }
}
