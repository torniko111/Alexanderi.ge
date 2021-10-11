using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexanderi.ge.Models
{
    public class MockProductCategoryRepository : IProductCategoryRepository
    {
        public IEnumerable<ProductCategory> GetAllCategories { get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
    }
}
