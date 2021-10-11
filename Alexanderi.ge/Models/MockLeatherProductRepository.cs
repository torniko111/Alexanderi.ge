using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexanderi.ge.Models
{
    public class MockLeatherProductRepository : ILeatherProductRepository
    {

        private List<LeatherProduct> _leatherProducts;

        public MockLeatherProductRepository()
        {
            _leatherProducts = new List<LeatherProduct>()
            {
                new LeatherProduct() {Id = 1, Name = "mary", Descriptions="100 % leather", Price=90.00M, ProductCategoryId = 1},
                new LeatherProduct() {Id = 2, Name = "jhon", Descriptions="100 % leather", Price=65.00M, ProductCategoryId = 1},
                new LeatherProduct() {Id = 3, Name = "gela", Descriptions="100 % leather", Price=75.00M, ProductCategoryId = 3},
            };
        }

        public LeatherProduct CreateNew(LeatherProduct leather)
        {
            throw new NotImplementedException();
        }

        public LeatherProduct Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeatherProduct> GetAllLeatherProducts()
        {
            throw new NotImplementedException();
        }

        public LeatherProduct GetLeatherProduct(int Id)
        {
            return _leatherProducts.FirstOrDefault(e => e.Id == Id);
        }

        public LeatherProduct Update(LeatherProduct leather)
        {
            throw new NotImplementedException();
        }
    }
}
