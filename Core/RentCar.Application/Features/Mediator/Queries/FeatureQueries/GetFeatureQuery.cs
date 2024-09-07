using MediatR;
using RentCar.Application.Features.Mediator.Results.FeatureResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>    //Mediatr çağırdık.Getfeaturequery'i çağırdığımda liste türünde result olan gelicek
    {

    }
}
