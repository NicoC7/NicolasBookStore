using NicolasBooks.Models;
using NicolasBookStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
namespace NicolasBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository 
    {
        void Update(Category category);

        object GetAll(); // Adding this Line to resolve an error in the category controller
        Category Get(int v); // Adding this line to fix issues
        void Add(Category category); // Line added by the qick solution
        void Remove(Category objFromDb);
    }
}
