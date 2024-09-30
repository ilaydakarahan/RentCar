using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Interfaces.ICarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        Task<List<CarFeature>> GetCarFeatureByCarId(int id);
        Task ChangeCarFeatureAvailableToFalse(int id);
        Task ChangeCarFeatureAvailableToTrue(int id);
        Task CreateCarFeatureByCar(CarFeature carFeature);
    }
}
