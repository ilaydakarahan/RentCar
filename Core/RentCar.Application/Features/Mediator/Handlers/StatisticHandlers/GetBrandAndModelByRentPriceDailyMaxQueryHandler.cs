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
    public class GetBrandAndModelByRentPriceDailyMaxQueryHandler : IRequestHandler<GetBrandAndModelByRentPriceDailyMaxQuery, GetBrandAndModelByRentPriceDailyMaxQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetBrandAndModelByRentPriceDailyMaxQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetBrandAndModelByRentPriceDailyMaxQueryResult> Handle(GetBrandAndModelByRentPriceDailyMaxQuery request, CancellationToken cancellationToken)
        {
            return new GetBrandAndModelByRentPriceDailyMaxQueryResult
            {
                BrandAndModelByRentPriceDailyMax = await _statisticRepository.GetBrandAndModelByRentPriceDailyMax()
            };
        }
    }
}
