﻿using MediatR;
using RentCar.Application.Features.Mediator.Results.TagCloudResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByIdQuery : IRequest<GetTagCloudByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTagCloudByIdQuery(int id)
        {
            Id = id;
        }
    }
}
