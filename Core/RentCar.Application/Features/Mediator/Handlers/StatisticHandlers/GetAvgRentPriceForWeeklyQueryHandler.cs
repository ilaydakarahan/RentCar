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
    public class GetAvgRentPriceForWeeklyQueryHandler : IRequestHandler<GetAvgRentPriceForWeeklyQuery, GetAvgRentPriceForWeeklyQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetAvgRentPriceForWeeklyQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetAvgRentPriceForWeeklyQueryResult> Handle(GetAvgRentPriceForWeeklyQuery request, CancellationToken cancellationToken)
        {
            return new GetAvgRentPriceForWeeklyQueryResult
            {
                AvgPriceForWeekly = await _statisticRepository.GetAvgRentPriceForWeekly()
            };
        }
    }
}
