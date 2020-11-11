﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UNFBooks.Models;
using UNFBooks.Models.ViewModels;

namespace UNFBooks.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public int PageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category,int page = 1) 
            => View(new ProductsListViewModel
            { 
                Products = repository.Products
                    .Where(p => category == null || p.BookGenre == category)
                    .OrderBy(p => p.Id)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                     TotalItems = category == null ?
                     repository.Products.Count() :
                     repository.Products.Where(e =>
                        e.BookGenre == category).Count()
                },
                CurrentCategory = category
            });
    }
}

