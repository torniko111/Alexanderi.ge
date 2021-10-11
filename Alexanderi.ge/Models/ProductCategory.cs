﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexanderi.ge.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        ICollection<LeatherProduct> leatherProducts { get; set; }
    }
}
