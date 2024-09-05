using RentCar.Application.Features.CQRS.Queries.CarQueries;
using RentCar.Application.Features.CQRS.Results.CarResults;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.CQRS.Handlers.CarHandlers.Read
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;
        //private readonly ICarRepository _carRepository;
        public GetCarByIdQueryHandler(IRepository<Car> repository/*, ICarRepository carRepository*/)
        {
            _repository = repository;
            //_carRepository = carRepository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                CarId = values.CarId,
                BigImageUrl = values.BigImageUrl,
                BrandId = values.BrandId,
                CoverImageUrl = values.CoverImageUrl,
                //BrandName = values.Brand.Name,
                Fuel = values.Fuel,
                Km = values.Km,
                Luggage = values.Luggage,
                Model = values.Model,
                Seat = values.Seat,
                Transmission = values.Transmission
            };

        }
    }
}
