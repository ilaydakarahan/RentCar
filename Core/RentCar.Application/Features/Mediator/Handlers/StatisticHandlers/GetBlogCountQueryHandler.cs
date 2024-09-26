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
    public class GetBlogCountQueryHandler : IRequestHandler<GetBlogCountQuery, GetBlogCountQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetBlogCountQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetBlogCountQueryResult> Handle(GetBlogCountQuery request, CancellationToken cancellationToken)
        {
            return new GetBlogCountQueryResult
            {
                BlogCount = await _statisticRepository.GetBlogCount()
            };
        }
    }

}
