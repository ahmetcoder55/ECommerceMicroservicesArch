using AutoMapper;
using MediatR;
using Order.Business.Concrete.DTOs;
using Order.DataAccess.Abstract.UnitOfWorks;
using Order.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Business.Concrete.Features.Order.Queries
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, OrderDto>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public GetOrderByIdQueryHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _manager.OrderRepository.GetByIdAsync(request.Id);
            return _mapper.Map<OrderDto>(order);
        }
    }
}
