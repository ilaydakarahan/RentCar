﻿using MediatR;
using RentCar.Application.Features.Mediator.Commands.ReservationCommands;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
    {
        private readonly IRepository<Reservation> _repository;

        public CreateReservationCommandHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {

            await _repository.CreateAsync(new Reservation
            {
                Age = request.Age,
                Description = request.Description,
                DriverLicenseYear = request.DriverLicenseYear,
                DropOffLocationId = request.DropOffLocationId,
                Email = request.Email,
                Name = request.Name,
                Phone = request.Phone,
                PickupLocationId = request.PickupLocationId,
                CarId = request.CarId,
                Surname = request.Surname,
                Status = "Rezervasyon Alındı",

            });
        }
    }
}
