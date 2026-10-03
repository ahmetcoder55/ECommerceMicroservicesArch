using MediatR;
using Order.DataAccess.Abstract.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Business.Concrete.Features.Order.Commands
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, bool>
    {
        private readonly IRepositoryManager _manager;

        public DeleteOrderCommandHandler(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _manager.OrderRepository.GetByIdAsync(request.Id);
            if(order is not null)
            {
                _manager.OrderRepository.Delete(order);
                await _manager.SaveAsync();
            }
            return false;
        }
    }
}
