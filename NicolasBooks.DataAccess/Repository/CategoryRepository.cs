using NicolasBooks.DataAccess.Repository.IRepository;
using NicolasBooks.Models;
using NicolasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NicolasBooks.DataAccess.Repository
{
    public class CategoryRepository :  Repository<Category>,  ICategoryRepository 
    {

        private readonly ApplicationDbContext _db;
        public  CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //throw new NotImplementedException();
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) //save changes
            {

                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
