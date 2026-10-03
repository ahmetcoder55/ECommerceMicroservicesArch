using MediatR;

namespace Order.Business.Concrete.Features.Order.Commands
{
    public record DeleteOrderCommand(int Id) : IRequest<Boolean>;
  
  
}
