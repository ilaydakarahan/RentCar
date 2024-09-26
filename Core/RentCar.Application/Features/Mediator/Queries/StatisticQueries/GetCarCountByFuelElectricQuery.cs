using MediatR;
using RentCar.Application.Features.Mediator.Results.StatisticResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Queries.StatisticQueries
{
    public class GetCarCountByFuelElectricQuery : IRequest<GetCarCountByFuelElectricQueryResult>
    {
    }
}
