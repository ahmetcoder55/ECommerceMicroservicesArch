using MediatR;

namespace Product.Business.Concrete.Features.Products.Commands
{
    public record UpdateProductCommand(
        int Id,
    string Name,
    string Description,
    decimal Price,
    int Stock
        ) : IRequest<Boolean>;
    
}
