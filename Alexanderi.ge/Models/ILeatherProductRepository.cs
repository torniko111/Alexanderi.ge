using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexanderi.ge.Models
{
    public interface ILeatherProductRepository
    {
        LeatherProduct GetLeatherProduct(int id);
        IEnumerable<LeatherProduct> GetAllLeatherProducts();
        LeatherProduct CreateNew(LeatherProduct leather);
        LeatherProduct Delete(int id);
        LeatherProduct Update(LeatherProduct leather);
    }
}
