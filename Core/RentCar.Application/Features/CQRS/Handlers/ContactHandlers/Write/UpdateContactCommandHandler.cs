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
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand contact)
        {
            var value = await _repository.GetByIdAsync(contact.ContactId);
            value.Name = contact.Name;
            value.SendDate = contact.SendDate;
            value.Email = contact.Email;
            value.Subject = contact.Subject;
            await _repository.UpdateAsync(value);
        }
    }
}
