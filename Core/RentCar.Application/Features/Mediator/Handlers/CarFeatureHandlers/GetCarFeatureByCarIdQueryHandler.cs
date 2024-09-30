using MediatR;
using RentCar.Application.Features.Mediator.Queries.CarFeatureQueries;
using RentCar.Application.Features.Mediator.Results.CarFeatureResults;
using RentCar.Application.Interfaces.ICarFeatureInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
    {
        private readonly ICarFeatureRepository _carFeatureRepository;

        public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _carFeatureRepository.GetCarFeatureByCarId(request.Id);

            return values.Select(t => new GetCarFeatureByCarIdQueryResult
            {
                CarId = t.CarId,
                Available = t.Available,
                CarFeatureId = t.CarFeatureId,
                FeatureId = t.FeatureId,
                FeatureName = t.Feature.Name,
            }).ToList();
        }
    }
}
