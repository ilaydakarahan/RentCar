using MediatR;
using RentCar.Application.Features.Mediator.Queries.LocationQueries;
using RentCar.Application.Features.Mediator.Results.LocationResults;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.LocationHandlers.Read
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery,List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repoistory;

        public GetLocationQueryHandler(IRepository<Location> repoistory)
        {
            _repoistory = repoistory;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repoistory.GetAllAsync();
            return values.Select(x => new GetLocationQueryResult
            {
                LocationId = x.LocationId,
                Name = x.Name
            }).ToList();
        }
    }
}
