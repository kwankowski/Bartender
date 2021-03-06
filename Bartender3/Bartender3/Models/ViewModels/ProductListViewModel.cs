﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bartender3.Models;

namespace Bartender3.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
