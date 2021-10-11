﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexanderi.ge.Models
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetAllCategories { get; set; }
    }
}
