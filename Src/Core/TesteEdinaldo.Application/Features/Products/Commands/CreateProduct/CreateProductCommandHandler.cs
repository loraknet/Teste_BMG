using System.Threading;
using System.Threading.Tasks;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Interfaces.Repositories;
using TesteEdinaldo.Application.Wrappers;
using TesteEdinaldo.Domain.Products.Entities;

namespace TesteEdinaldo.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price, request.BarCode);

            await productRepository.AddAsync(product);
            await unitOfWork.SaveChangesAsync();

            return product.Id;
        }
    }
}
