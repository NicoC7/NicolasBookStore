using NicolasBooks.Models;

namespace NicolasBookStore.Areas.Admin.Controllers
{
    internal class ProductVM
    {
        public Product Product { get; internal set; }
        public object CategoryList { get; internal set; }
        public object CoverTypeList { get; internal set; }
    }
}