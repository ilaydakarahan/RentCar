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
    public class GetBrandAndModelByRentPriceDailyMinQueryHandler : IRequestHandler<GetBrandAndModelByRentPriceDailyMinQuery, GetBrandAndModelByRentPriceDailyMinQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetBrandAndModelByRentPriceDailyMinQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetBrandAndModelByRentPriceDailyMinQueryResult> Handle(GetBrandAndModelByRentPriceDailyMinQuery request, CancellationToken cancellationToken)
        {
            return new GetBrandAndModelByRentPriceDailyMinQueryResult
            {
                BrandAndModelByRentPriceDailyMin = await _statisticRepository.GetBrandAndModelByRentPriceDailyMin()
            };
        }
    }
}
