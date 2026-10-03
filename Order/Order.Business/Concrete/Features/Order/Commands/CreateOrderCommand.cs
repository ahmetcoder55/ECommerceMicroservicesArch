using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Business.Concrete.Features.Order.Commands
{
    public record CreateOrderCommand(int ProductId,
    int Quantity,
    decimal TotalPrice,
    string CustomerEmail) : IRequest<int>;
  
  
}
