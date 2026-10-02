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
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductDto>>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<List<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _manager.Product.GetAllAsync();
            if (products == null)
            {
                throw new NotFoundDataException();
            }
            return _mapper.Map<List<ProductDto>>(products);
        }
    }
}
