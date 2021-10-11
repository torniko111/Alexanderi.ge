using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexanderi.ge.Models
{
    public class LeatherProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public decimal  Price { get; set; }
        public int ProductCategoryId { get; set; }
        ProductCategory ProductCategory { get; set; }
    }
}
