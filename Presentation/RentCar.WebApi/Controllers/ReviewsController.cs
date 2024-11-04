﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar.Application.Features.Mediator.Queries.ReviewQueries;

namespace RentCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReviewsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCarReviewByCarId(int CarId)
        {
            var values = await _mediator.Send(new GetReviewByCarIdQuery(CarId));
            return Ok(values);
        }

        //[HttpGet("GetCarReviewDetailByCarId")]
        //public async Task<IActionResult> GetCarReviewDetailByCarId(int CarId)
        //{
        //    var values = await _mediator.Send(new GetReviewByCarIdQuery(CarId));
        //    return Ok(values);
        //}
        //[HttpPost]
        //public async Task<IActionResult> CreateReview(CreateReviewCommand command)
        //{
        //    var validator = new CreateReviewValidator();
        //    var result = validator.Validate(command);
        //    if (!result.IsValid)
        //    {
        //        return BadRequest(result.Errors);
        //    }
        //    await _mediator.Send(command);
        //    return Ok();
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateReview(UpdateReviewCommand command)
        //{
        //    await _mediator.Send(command);
        //    return Ok();
        //}
    }
}
