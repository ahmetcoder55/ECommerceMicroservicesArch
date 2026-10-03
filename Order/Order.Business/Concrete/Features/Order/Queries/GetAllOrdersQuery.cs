using MediatR;
using Order.Business.Concrete.DTOs;
using Order.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Business.Concrete.Features.Order.Queries
{
    public record GetAllOrdersQuery:IRequest<List<OrderDto>>
    {
    }
}
