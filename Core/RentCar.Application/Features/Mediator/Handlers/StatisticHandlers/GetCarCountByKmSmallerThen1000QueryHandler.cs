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
    public class GetCarCountByKmSmallerThen1000QueryHandler : IRequestHandler<GetCarCountByKmSmallerThen1000Query, GetCarCountByKmSmallerThen1000QueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetCarCountByKmSmallerThen1000QueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetCarCountByKmSmallerThen1000QueryResult> Handle(GetCarCountByKmSmallerThen1000Query request, CancellationToken cancellationToken)
        {
            return new GetCarCountByKmSmallerThen1000QueryResult
            {
                CarCountByKmSmallerThen1000 = await _statisticRepository.GetCarCountByKmSmallarThen1000()
            };
        }
    }
}
