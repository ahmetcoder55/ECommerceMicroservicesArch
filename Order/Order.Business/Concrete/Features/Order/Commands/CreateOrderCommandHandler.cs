using AutoMapper;
using MediatR;
using Order.DataAccess.Abstract.UnitOfWorks;
using Order.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Business.Concrete.Features.Order.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<OrderEntity>(request);
            if(order is not null)
            {
                await _manager.OrderRepository.AddAsync(order);
                await _manager.SaveAsync();
            }
            throw new Exception();
        }
    }
}
