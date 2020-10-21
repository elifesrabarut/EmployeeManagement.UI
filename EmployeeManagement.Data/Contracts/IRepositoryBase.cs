using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeManagement.Data.Contracts
{
    public interface IRepositoryBase<T> where T:class,new()
    {
        IQueryable<T> GetAll(Expression<Func<T,bool>> filter=null,Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null, string includeProperties = null);
        T Get(int id);// numaraya göre veri cekmek için
        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);

    }
    
}
