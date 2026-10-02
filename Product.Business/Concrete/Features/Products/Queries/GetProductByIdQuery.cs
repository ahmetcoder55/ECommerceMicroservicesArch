using MediatR;
using Product.Business.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Business.Concrete.Features.Products.Queries
{
    public record GetProductByIdQuery(int Id):IRequest<ProductDto>
    {
    }
}
