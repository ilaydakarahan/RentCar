﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar.Application.Features.Mediator.Commands.ReservationCommands;

namespace RentCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> AddReservation(CreateReservationCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
