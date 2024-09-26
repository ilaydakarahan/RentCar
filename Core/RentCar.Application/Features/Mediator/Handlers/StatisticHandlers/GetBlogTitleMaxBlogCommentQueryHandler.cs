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
    public class GetBlogTitleMaxBlogCommentQueryHandler : IRequestHandler<GetBlogTitleMaxBlogCommentQuery, GetBlogTitleMaxBlogCommentQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetBlogTitleMaxBlogCommentQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetBlogTitleMaxBlogCommentQueryResult> Handle(GetBlogTitleMaxBlogCommentQuery request, CancellationToken cancellationToken)
        {
            return new GetBlogTitleMaxBlogCommentQueryResult
            {
                Title = await _statisticRepository.GetBlogTitleMaxBlogComment()
            };
        }
    }
}
