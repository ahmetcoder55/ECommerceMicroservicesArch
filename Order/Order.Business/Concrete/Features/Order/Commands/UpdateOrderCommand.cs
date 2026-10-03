using MediatR;

namespace Order.Business.Concrete.Features.Order.Commands
{
    public record UpdateOrderCommand(
        int Id,
    int ProductId,
    int Quantity,
    decimal TotalPrice,
    string CustomerEmail
        ) : IRequest<bool>;
  
  
}
