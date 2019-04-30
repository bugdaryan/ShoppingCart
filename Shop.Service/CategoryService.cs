﻿using Shop.Data;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Service
{
    public class CategoryService : ICategory
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        public Category GetById(int id)
        {
            return GetAll().FirstOrDefault(category => category.Id == id);
        }
    }
}
