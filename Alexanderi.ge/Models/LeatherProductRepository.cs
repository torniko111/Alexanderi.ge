using Alexanderi.ge.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexanderi.ge.Models
{
    public class LeatherProductRepository : ILeatherProductRepository
    {
        private readonly AppDbContext context;

        public LeatherProductRepository(AppDbContext context)
        {
            this.context = context;
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

        public LeatherProduct GetLeatherProduct(int id)
        {
            throw new NotImplementedException();
        }

        public LeatherProduct Update(LeatherProduct leather)
        {
            throw new NotImplementedException();
        }
    }
}
