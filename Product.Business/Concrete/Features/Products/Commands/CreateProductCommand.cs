using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Business.Concrete.Features.Products.Commands
{
    public record CreateProductCommand(string Name,
    string Description,
    decimal Price,
    int Stock) : IRequest<int>;
    
}
