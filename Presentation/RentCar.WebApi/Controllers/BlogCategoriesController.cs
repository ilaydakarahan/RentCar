using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar.Application.Features.CQRS.Commands.BlogCategoryCommands;
using RentCar.Application.Features.CQRS.Handlers.BlogCategoryHandlers.Read;
using RentCar.Application.Features.CQRS.Handlers.BlogCategoryHandlers.Write;
using RentCar.Application.Features.CQRS.Queries.BlogCategoryQueries;

namespace RentCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController : ControllerBase
    {
        private readonly CreateBlogCategoryCommandHandler _createCommandHandler;
        private readonly GetBlogCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly GetBlogCategoryQueryHandler _getCategoryQueryHandler;
        private readonly UpdateBlogCategoryCommandHandler _updateCategoryCommandHandler;
        private readonly RemoveBlogCategoryCommandHandler _removeCategoryCommandHandler;
        public BlogCategoriesController(CreateBlogCategoryCommandHandler createCommandHandler, 
            GetBlogCategoryByIdQueryHandler getCategoryByIdQueryHandler, 
            GetBlogCategoryQueryHandler getCategoryQueryHandler, 
            UpdateBlogCategoryCommandHandler updateCategoryCommandHandler,
            RemoveBlogCategoryCommandHandler removeCategoryCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BlogCategoryList()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogCategory(int id)
        {
            var value = await _getCategoryByIdQueryHandler.Handle(new GetBlogCategoryByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlogCategory(CreateBlogCategoryCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBlogCategory(int id)
        {
            await _removeCategoryCommandHandler.Handle(new RemoveBlogCategoryCommand(id));
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlogCategory(UpdateBlogCategoryCommand command)
        {
            await _updateCategoryCommandHandler.Handle(command);
            return Ok();
        }
    }
}
