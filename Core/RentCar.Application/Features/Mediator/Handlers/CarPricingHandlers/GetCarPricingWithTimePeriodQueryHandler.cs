using MediatR;
using RentCar.Application.Features.Mediator.Queries.CarPricingQueries;
using RentCar.Application.Features.Mediator.Results.CarPricingResults;
using RentCar.Application.Interfaces.CarPricingInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {

            var values =await _carPricingRepository.GetCarPricingWithTimePeriod();
            return values.ToList();

            //var values = await _carPricingRepository.GetCarPricingWithTimePeriod();
            //return values.Select(u => new GetCarPricingWithTimePeriodQueryResult
            //{
            //    CoverPhoto = u.CoverPhoto,
            //    DailyAmount = u.DailyAmount,
            //    CarId = u.CarId,
            //    Model = u.Model,
            //    MonthlyAmount = u.MonthlyAmount,
            //    WeeklyAmount = u.WeeklyAmount

            //}).ToList();
        }
    }
}
