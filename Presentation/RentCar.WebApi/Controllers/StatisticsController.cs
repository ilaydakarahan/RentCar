using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar.Application.Features.Mediator.Queries.StatisticQueries;

namespace RentCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var value = await _mediator.Send(new GetCarCountQuery());
            return Ok(value);
        }

        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var value = await _mediator.Send(new GetLocationCountQuery());
            return Ok(value);
        }
        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var value = await _mediator.Send(new GetAuthorCountQuery());
            return Ok(value);
        }
        [HttpGet("GetBlogCount")]
        public async Task<IActionResult> GetBlogCount()
        {
            var value = await _mediator.Send(new GetBlogCountQuery());
            return Ok(value);
        }
        [HttpGet("GetBrandCount")]
        public async Task<IActionResult> GetBrandCount()
        {
            var value = await _mediator.Send(new GetBrandCountQuery());
            return Ok(value);
        } 
        [HttpGet("GetAvgRentPriceForDaily")]
        public async Task<IActionResult> GetAvgRentPriceForDaily()
        {
            var value = await _mediator.Send(new GetAvgRentPriceForDailyQuery());
            return Ok(value);
        }
        [HttpGet("GetAvgRentPriceForWeekly")]
        public async Task<IActionResult> GetAvgRentPriceForWeekly()
        {
            var value = await _mediator.Send(new GetAvgRentPriceForWeeklyQuery());
            return Ok(value);
        }
        [HttpGet("GetAvgRentPriceForMonthly")]
        public async Task<IActionResult> GetAvgRentPriceForMonthly()
        {
            var value = await _mediator.Send(new GetAvgRentPriceForMonthlyQuery());
            return Ok(value);
        } 
        [HttpGet("GetCarCountByTranmissionIsAuto")]
        public async Task<IActionResult> GetCarCountByTranmissionIsAuto()
        {
            var value = await _mediator.Send(new GetCarCountByTransmissionsIsAutoQuery());
            return Ok(value);
        } 
        [HttpGet("GetBrandNameByMaxCar")]
        public async Task<IActionResult> GetBrandNameByMaxCar()
        {
            var value = await _mediator.Send(new GetBrandNameMaxCarQuery());
            return Ok(value);
        }
        [HttpGet("GetBlogTitleMaxBlogComment")]
        public async Task<IActionResult> GetBlogTitleMaxBlogComment()
        {
            var value = await _mediator.Send(new GetBlogTitleMaxBlogCommentQuery());
            return Ok(value);
        }
        [HttpGet("GetCarCountByKmSmallarThen1000")]
        public async Task<IActionResult> GetCarCountByKmSmallarThen1000()
        {
            var value = await _mediator.Send(new GetCarCountByKmSmallerThen1000Query());
            return Ok(value);
        }
        [HttpGet("GetCarCountByFuelGasolineOrDisel")]
        public async Task<IActionResult> GetCarCountByFuelGasolineOrDisel()
        {
            var value = await _mediator.Send(new GetCarCountByFuelGosalineOrDieselQuery());
            return Ok(value);
        }
        [HttpGet("GetCarCountFuelElectric")]
        public async Task<IActionResult> GetCarCountFuelElectric()
        {
            var value = await _mediator.Send(new GetCarCountByFuelElectricQuery());
            return Ok(value);
        }
        [HttpGet("GetBrandAndModelByRentPriceDailyMax")]
        public async Task<IActionResult> GetBrandAndModelByRentPriceDailyMax()
        {
            var value = await _mediator.Send(new GetBrandAndModelByRentPriceDailyMaxQuery());
            return Ok(value);
        }
        [HttpGet("GetBrandAndModelByRentPriceDailyMin")]
        public async Task<IActionResult> GetBrandAndModelByRentPriceDailyMin()
        {
            var value = await _mediator.Send(new GetBrandAndModelByRentPriceDailyMinQuery());
            return Ok(value);
        }





    }
}
