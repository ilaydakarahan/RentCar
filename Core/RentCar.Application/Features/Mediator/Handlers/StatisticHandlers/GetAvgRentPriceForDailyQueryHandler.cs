using MediatR;
using RentCar.Application.Features.Mediator.Queries.StatisticQueries;
using RentCar.Application.Features.Mediator.Results.StatisticResults;
using RentCar.Application.Interfaces.StatisticInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetAvgRentPriceForDailyQueryHandler : IRequestHandler<GetAvgRentPriceForDailyQuery, GetAvgRentPriceForDailyQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetAvgRentPriceForDailyQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetAvgRentPriceForDailyQueryResult> Handle(GetAvgRentPriceForDailyQuery request, CancellationToken cancellationToken)
        {
            return new GetAvgRentPriceForDailyQueryResult
            {
                AvgPriceForDaily = await _statisticRepository.GetAvgRentPriceForDaily()
            };
        }
    }
}
