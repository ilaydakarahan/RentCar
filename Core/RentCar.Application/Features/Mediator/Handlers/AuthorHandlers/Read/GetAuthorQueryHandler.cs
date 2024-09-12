using MediatR;
using RentCar.Application.Features.Mediator.Queries.AuthorQueries;
using RentCar.Application.Features.Mediator.Results.AuthorResults;
using RentCar.Application.Interfaces;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Features.Mediator.Handlers.AuthorHandlers.Read
{
    public class GetBlogQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;

        public GetBlogQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x => new GetAuthorQueryResult
            {
                AuthorId = x.AuthorId,
                Description = x.Description,
                ImageURL = x.ImageURL,
                Name = x.Name
            }).ToList();
        }
    }
}
