using MediatR;
using RentCar.Application.Features.Mediator.Results.RentACarResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Queries.RentACarQueries
{
    public class GetRentACarQuery : IRequest<List<GetRentACarQueryResult>>
    {
        public int LocationId { get; set; }
        public bool Available { get; set; }
    }
}
