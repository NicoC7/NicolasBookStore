using NicolasBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace NicolasBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository
    {
        void Update(Category category);
        object GetAll(); // Adding this Line to resolve an error in the category controller
    }
}
