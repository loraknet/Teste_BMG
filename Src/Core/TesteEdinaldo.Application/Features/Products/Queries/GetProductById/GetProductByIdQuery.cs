using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Wrappers;
using TesteEdinaldo.Domain.Products.DTOs;

namespace TesteEdinaldo.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
