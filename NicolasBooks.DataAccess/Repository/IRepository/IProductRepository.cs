using NicolasBooks.Models;
using NicolasBookStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;

namespace NicolasBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}