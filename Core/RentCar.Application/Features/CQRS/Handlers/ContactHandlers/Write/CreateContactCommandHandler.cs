using RentCar.Application.Features.CQRS.Commands.ContactCommands;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Handlers.ContactHandlers.Write
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateContactCommand contact)
        {
            await _repository.CreateAsync(new Contact
            {
                Name = contact.Name,
                Subject = contact.Subject,
                Email = contact.Email,
                Message = contact.Message,
                SendDate = contact.SendDate,
            });
        }
    }
}
