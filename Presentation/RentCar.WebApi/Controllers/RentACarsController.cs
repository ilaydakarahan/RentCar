using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar.Application.Features.Mediator.Queries.RentACarQueries;

namespace RentCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RentACarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetRentACarListByLocation(int locationId, bool available)  //Burdaki parametreler swagger'da çıkıyor.
        {
            GetRentACarQuery query = new GetRentACarQuery
            {
                Available = available,
                LocationId = locationId
            };
            var values = await _mediator.Send(query);
            return Ok(values);
        }
    }
}
