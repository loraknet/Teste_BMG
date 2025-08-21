using System.Threading;
using System.Threading.Tasks;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Interfaces.Repositories;
using TesteEdinaldo.Application.Wrappers;
using TesteEdinaldo.Domain.Products.DTOs;

namespace TesteEdinaldo.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetPagedListProductQuery, PagedResponse<ProductDto>>
    {
        public async Task<PagedResponse<ProductDto>> Handle(GetPagedListProductQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}
