using MediatR;
using Order.Business.Concrete.DTOs;
using Order.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Business.Concrete.Features.Order.Queries
{
    public record GetOrderByIdQuery(int Id) : IRequest<OrderDto>;
    
}
