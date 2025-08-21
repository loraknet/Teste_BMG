using System.Threading.Tasks;
using TesteEdinaldo.Application.DTOs;
using TesteEdinaldo.Domain.Products.DTOs;
using TesteEdinaldo.Domain.Products.Entities;

namespace TesteEdinaldo.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
