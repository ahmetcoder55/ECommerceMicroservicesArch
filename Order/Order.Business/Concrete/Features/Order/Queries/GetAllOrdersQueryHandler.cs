using AutoMapper;
using MediatR;
using Order.Business.Concrete.DTOs;
using Order.DataAccess.Abstract.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Business.Concrete.Features.Order.Queries
{
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, List<OrderDto>>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public GetAllOrdersQueryHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<List<OrderDto>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _manager.OrderRepository.GetAllAsync();
            return _mapper.Map<List<OrderDto>>(orders);
        }
    }
}
