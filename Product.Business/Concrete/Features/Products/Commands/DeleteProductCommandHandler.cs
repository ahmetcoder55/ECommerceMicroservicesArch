using AutoMapper;
using MediatR;
using Product.DataAccess.Abstract.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Business.Concrete.Features.Products.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IRepositoryManager _manager;

        public DeleteProductCommandHandler(IRepositoryManager manager)
        {
            _manager = manager;
        
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _manager.Product.GetByIdAsync(request.Id);
            if (product != null)
            {
                _manager.Product.Delete(product);
                await _manager.SaveAsync();
            }
            return false;
        }
    }
}
