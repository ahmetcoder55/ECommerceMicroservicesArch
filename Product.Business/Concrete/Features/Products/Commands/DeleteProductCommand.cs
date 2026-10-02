using MediatR;

namespace Product.Business.Concrete.Features.Products.Commands
{
    public record DeleteProductCommand(int Id) : IRequest<Boolean>;
    
}
