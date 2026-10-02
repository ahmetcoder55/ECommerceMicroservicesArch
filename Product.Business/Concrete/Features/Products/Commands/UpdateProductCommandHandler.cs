using AutoMapper;
using MediatR;
using Product.DataAccess.Abstract.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Business.Concrete.Features.Products.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = await _manager.Product.GetByIdAsync(request.Id);
            if (entity == null) return false;

            _mapper.Map(request, entity); 

            _manager.Product.Update(entity);
            await _manager.SaveAsync();

            return true;
        }
    }
}
