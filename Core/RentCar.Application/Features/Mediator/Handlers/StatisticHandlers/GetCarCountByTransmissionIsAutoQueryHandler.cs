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
    public class GetCarCountByTransmissionIsAutoQueryHandler : IRequestHandler<GetCarCountByTransmissionsIsAutoQuery, GetCarCountByTransmissionIsAutoQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetCarCountByTransmissionIsAutoQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetCarCountByTransmissionIsAutoQueryResult> Handle(GetCarCountByTransmissionsIsAutoQuery request, CancellationToken cancellationToken)
        {
            return new GetCarCountByTransmissionIsAutoQueryResult
            {
                CarCountByTransmissionIsAutoCount = await _statisticRepository.GetCarCountByTranmissionIsAuto()
            };
        }
    }
}
