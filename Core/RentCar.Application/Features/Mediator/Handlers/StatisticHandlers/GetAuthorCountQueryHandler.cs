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
    public class GetAuthorCountQueryHandler : IRequestHandler<GetAuthorCountQuery, GetAuthorCountQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetAuthorCountQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetAuthorCountQueryResult> Handle(GetAuthorCountQuery request, CancellationToken cancellationToken)
        {
            return new GetAuthorCountQueryResult
            {
                AuthorCount = await _statisticRepository.GetAuthorCount()
            };
        }
    }
}
