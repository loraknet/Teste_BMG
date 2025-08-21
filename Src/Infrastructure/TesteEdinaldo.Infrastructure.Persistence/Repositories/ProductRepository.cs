using System.Linq;
using System.Threading.Tasks;
using TesteEdinaldo.Application.DTOs;
using TesteEdinaldo.Application.Interfaces.Repositories;
using TesteEdinaldo.Domain.Products.DTOs;
using TesteEdinaldo.Domain.Products.Entities;
using TesteEdinaldo.Infrastructure.Persistence.Contexts;

namespace TesteEdinaldo.Infrastructure.Persistence.Repositories
{
    public class ProductRepository(ApplicationDbContext dbContext) : GenericRepository<Product>(dbContext), IProductRepository
    {
        public async Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = dbContext.Products.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            return await Paged(
                query.Select(p => new ProductDto(p)),
                pageNumber,
                pageSize);

        }
    }
}
