using Order.DataAccess.Abstract.Repositories;
using Order.DataAccess.Abstract.UnitOfWorks;
using Order.DataAccess.Concrete.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.DataAccess.Concrete.UnitOfWorks
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly OrderContext _context;
        private readonly IOrderRepository _orderRepository;

        public RepositoryManager(OrderContext context, IOrderRepository orderRepository)
        {
            _context = context;
            _orderRepository = orderRepository;
        }

        public IOrderRepository OrderRepository => _orderRepository;

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
