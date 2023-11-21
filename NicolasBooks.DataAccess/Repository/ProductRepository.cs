using NicolasBookStore.DataAccess.Data;

namespace NicolasBooks.DataAccess.Repository
{
    internal class ProductRepository
    {
        private ApplicationDbContext db;

        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
    }
}