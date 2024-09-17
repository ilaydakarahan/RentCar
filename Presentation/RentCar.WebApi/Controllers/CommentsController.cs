using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar.Application.Features.RepositoryPattern;
using RentCar.Domain.Entities;

namespace RentCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentRepository;

        public CommentsController(IGenericRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }
        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentRepository.GetAll();
            return Ok(values);
        }

        //[HttpPost]
        //public IActionResult CreateComment(CreateCommentDto comment)
        //{
        //    _commentRepository.Create(new Comment
        //    {
        //        BlogId = comment.BlogId,
        //        CreatedDate = comment.CreatedDate,
        //        Email = comment.Email,
        //        Name = comment.Name,
        //        CommentContent = comment.CommentContent
        //    });
        //    return Ok();
        //}
        //[HttpPut]
        //public IActionResult UpdateComment(UpdateCommentDto updateCommentDto)
        //{
        //    var value = _commentRepository.GetById(updateCommentDto.CommentID);
        //    value.BlogId = updateCommentDto.BlogId;
        //    value.Email = updateCommentDto.Email;
        //    value.CreatedDate = updateCommentDto.CreatedDate;
        //    value.Name = updateCommentDto.Name;
        //    value.CommentContent = updateCommentDto.CommentContent;
        //    _commentRepository.Update(value);
        //    return Ok();
        //}
        [HttpDelete("{id}")]
        public IActionResult RemoveComment(int id)
        {
            var value = _commentRepository.GetById(id);
            _commentRepository.Remove(value);
            return Ok();
        }
    }
}
