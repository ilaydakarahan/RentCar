using RentCar.Application.Features.CQRS.Commands.CarCommands;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Handlers.CarHandlers.Write
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarId);

            values.Luggage = command.Luggage;
            values.Seat = command.Seat;
            values.BigImageUrl = command.BigImageUrl;
            values.BrandId = command.BrandId;
            values.Fuel = command.Fuel;
            values.Transmission = command.Transmission;
            values.CoverImageUrl = command.CoverImageUrl;
            values.Km = command.Km;
            values.Model = command.Model;

            await _repository.UpdateAsync(values);

        }
    }
}
