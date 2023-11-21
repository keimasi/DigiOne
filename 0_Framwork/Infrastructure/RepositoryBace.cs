using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using _0_Framwork.Domain;
using Microsoft.EntityFrameworkCore;

namespace _0_Framwork.Infrastructure
{
    public class RepositoryBace<TKey,T> : IRepository<TKey,T> where T : class
    {
        private readonly DbContext _Context;

        public RepositoryBace(DbContext context)
        {
            _Context = context;
        }

        public void Create(T entity)
        {
            _Context.Add(entity);
        }

        public T Get(TKey id)
        {
            return _Context.Find<T>(id);
        }

        public List<T> GetAll()
        {
            return _Context.Set<T>().ToList();
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _Context.Set<T>().Any(expression);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
