using AutoMapper;
using MediatR;
using Product.Business.Concrete.DTOs;
using Product.Business.Concrete.Exceptions;
using Product.DataAccess.Abstract.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Business.Concrete.Features.Products.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _manager.Product.GetByIdAsync(request.Id);
            if(product is null)
            {
                throw new NotFoundDataException();
            }
            return _mapper.Map<ProductDto>(product);
        }
    }
}
