﻿using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products
{
    public class CreateProduct
    {
        private AppDbContext _context;

        public CreateProduct(AppDbContext context)
        {
            _context = context;
        }

        public void Do(int id, string name, string description)
        {
            _context.Products.Add(new Product
            {
                Id = id,
                Name = name,
                Description = description
            });
        }
    }
}
