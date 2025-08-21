using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Parameters;
using TesteEdinaldo.Application.Wrappers;
using TesteEdinaldo.Domain.Products.DTOs;

namespace TesteEdinaldo.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
