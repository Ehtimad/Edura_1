﻿using Edura.WebUI.Entity;
using Edura.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private EduraContext context;
        public EfCategoryRepository(EduraContext ctx)
        {
            context = ctx;
        }

        public void Add(Category entity)
        {
            context.Categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            context.Categories.Remove(entity);
        }

        public IQueryable<Category> Find(Expression<Func<Category, bool>> predicate)
        {
            return context.Categories.Where(predicate);
        }

        public Category Get(int id)
        {
            return context.Categories.FirstOrDefault(i => i.CategoryId == id);
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categories;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Category entity)
        {
            context.Entry<Category>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
