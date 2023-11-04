using NicolasBooks.DataAccess.Repository.IRepository;
using NicolasBooks.Models;
using NicolasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicolasBooks.DataAccess.Repository
{
    class UnitOfWork
    {

        private readonly ApplicationException _db; 
        private  UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public  ISP_Call SP_Call { get; private set; }

        public void  Disposes()
        {
                _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
