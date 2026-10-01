using Product.DataAccess.Abstract.Repositories;
using Product.DataAccess.Abstract.UnitOfWorks;
using Product.DataAccess.Concrete.Data.Context.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DataAccess.Concrete.UnitOfWorks
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ProductContext _context;
        private readonly IProductRepository _productRepository;

        public RepositoryManager(ProductContext context, IProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }

        public IProductRepository Product => _productRepository;

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
