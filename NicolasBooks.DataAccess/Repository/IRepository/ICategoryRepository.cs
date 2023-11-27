using NicolasBooks.Models;
using NicolasBookStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
namespace NicolasBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository :IRepository<Category>
    {
        void Update(Category category);
    }
}
