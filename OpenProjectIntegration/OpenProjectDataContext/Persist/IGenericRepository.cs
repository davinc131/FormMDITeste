using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OpenProjectDataContext.Persist
{
    public interface IGenericRepository
    {
        void Add<T>(T model) where T : class, new();
        void Update<T>(T model) where T : class, new();
        void Delete<T>(int id) where T : class, new();
        IList<T> GetAll<T>() where T : class, new();
        IList<T> Select<T>(Expression<Func<T, bool>> expression) where T : class, new();
    }
}
