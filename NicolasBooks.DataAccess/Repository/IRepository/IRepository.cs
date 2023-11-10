using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
namespace NicolasBookStore.DataAccess.Repository.IRepository
{
    interface IRepository<T> where T : class
    {

        T get(int id); // Retrive a category from the database by id 
        //List of all categories

        IEnumerable<T> getAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null // usefull for foreign key references
            );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            ); // I hadnt add this line

        void Add(T entity); //To add an entity
        void Remove(int id); // To remove an object or category 
        void Remove(T entity); // Another way to remove an object or category 
        void RemoveRange(IEnumerable<T> Entity); // Removes a complete range of entities  

    }
}
