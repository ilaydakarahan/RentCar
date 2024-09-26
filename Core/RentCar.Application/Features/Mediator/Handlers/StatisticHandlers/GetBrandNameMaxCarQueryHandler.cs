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
    public class GetBrandNameMaxCarQueryHandler : IRequestHandler<GetBrandNameMaxCarQuery, GetBrandNameMaxCarQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetBrandNameMaxCarQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetBrandNameMaxCarQueryResult> Handle(GetBrandNameMaxCarQuery request, CancellationToken cancellationToken)
        {
            return new GetBrandNameMaxCarQueryResult
            {
                BrandName = await _statisticRepository.GetBrandNameByMaxCar()
            };
        }
    }
}
