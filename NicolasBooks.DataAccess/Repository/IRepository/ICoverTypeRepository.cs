using NicolasBooks.Models;
using NicolasBookStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicolasBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository 
    {
        void Update(CoverType coverType);
    }
}
