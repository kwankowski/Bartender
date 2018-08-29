﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bartender3.Models;
using Bartender3.Models.ViewModels;

namespace Bartender3.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 5;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int page = 1)
            => View(new ProductListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.ProductID).Skip((page - 1) * PageSize)
                .Take(PageSize), PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
    }

  
}
