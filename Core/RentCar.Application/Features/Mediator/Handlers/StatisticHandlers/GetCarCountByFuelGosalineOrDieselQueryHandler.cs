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
    public class GetCarCountByFuelGosalineOrDieselQueryHandler : IRequestHandler<GetCarCountByFuelGosalineOrDieselQuery, GetCarCountByFuelGosalineOrDieselQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetCarCountByFuelGosalineOrDieselQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetCarCountByFuelGosalineOrDieselQueryResult> Handle(GetCarCountByFuelGosalineOrDieselQuery request, CancellationToken cancellationToken)
        {
            return new GetCarCountByFuelGosalineOrDieselQueryResult
            {
                CarCountByFuelGosalineOrDiesel = await _statisticRepository.GetCarCountByFuelGasolineOrDisel()
            };
        }
    }
}
