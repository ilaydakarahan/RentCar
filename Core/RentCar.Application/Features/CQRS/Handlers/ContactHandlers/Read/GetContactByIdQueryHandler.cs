using RentCar.Application.Features.CQRS.Queries.ContactQueries;
using RentCar.Application.Features.CQRS.Results.ContactResults;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Handlers.ContactHandlers.Read
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactQueryResult> Handle(GetContactByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetContactQueryResult
            {
                ContactId = values.ContactId,
                SendDate = values.SendDate,
                Email = values.Email,
                Message = values.Message,
                Subject = values.Subject,
                Name = values.Name,
            };
        }
    }
}
