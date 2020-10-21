﻿using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeManagement.Data.Implementaion
{
    public class Repository<T> : IRepositoryBase<T> where T : class, new()
    {
        private readonly UdemyEmployeeManagementContext _ctx;
        internal DbSet<T> dbSet;

        public Repository(UdemyEmployeeManagementContext ctx) 
        {
            _ctx = ctx;
            this.dbSet = ctx.Set <T>();
        }
        //gelen tipte veri kayıt eder
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter!=null)
            {
                query = query.Where(filter);
            }
            if (includeProperties!=null)
            {
                    foreach(var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            if (orderBy!=null)
            {
                return orderBy(query);
            }
            return query;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            
            return query.FirstOrDefault();
        }

    

    public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
