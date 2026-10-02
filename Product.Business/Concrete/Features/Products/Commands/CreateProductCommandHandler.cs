using AutoMapper;
using MediatR;
using Product.DataAccess.Abstract.UnitOfWorks;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Business.Concrete.Features.Products.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<ProductEntity>(request);
            if(product is null)
            {
                throw new ArgumentNullException();
            }
            await _manager.Product.AddAsync(product);
            await _manager.SaveAsync();
            return product.Id;
        }
    }
}
