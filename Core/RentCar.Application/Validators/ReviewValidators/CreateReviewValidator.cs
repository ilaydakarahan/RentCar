﻿using FluentValidation;
using RentCar.Application.Features.Mediator.Commands.ReviewCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Validators.ReviewValidators
{
    public class CreateReviewValidator: AbstractValidator<CreateReviewCommand>
    {
        public CreateReviewValidator()
        {
            RuleFor(x=>x.CustomerName).NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyiniz.");
            RuleFor(t => t.CustomerName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız");
            RuleFor(t => t.StarValue).NotEmpty().WithMessage("Lütfen puan değerini boş geçeyiniz");
            RuleFor(t => t.Comment).NotEmpty().WithMessage("Lütfen yorum değerini boş geçeyiniz");
            RuleFor(t => t.Comment).MinimumLength(50).WithMessage("Lütfen yorum kısmına en az 50 karakter veri girişi yapınız");
            RuleFor(t => t.Comment).MaximumLength(500).WithMessage("Lütfen yorum kısmına en fazla 500 karakter veri girişi yapınız");

        }
    }
}
