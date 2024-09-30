using MediatR;
using RentCar.Application.Features.Mediator.Commands.CarFeatureCommands;
using RentCar.Application.Interfaces.ICarFeatureInterfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.CarFeatureHandlers
{    
    public class CreateCarFeatureByCarCommandHandler : IRequestHandler<CreateCarFeatureByCarCommand>
    {
        private readonly ICarFeatureRepository _carFeatureRepository;

        public CreateCarFeatureByCarCommandHandler(ICarFeatureRepository carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
        {
            await _carFeatureRepository.CreateCarFeatureByCar(new CarFeature
            {
                Available = request.Available,
                CarId = request.CarId,
                FeatureId = request.FeatureId,
            });
        }
    }
}
