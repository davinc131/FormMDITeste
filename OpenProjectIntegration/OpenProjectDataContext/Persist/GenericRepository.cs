using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OpenProjectDataContext.Persist
{
    public class GenericRepository:IGenericRepository
    {
        private IRestClient _restClient;
        private OpenProjectContext _context;

        public GenericRepository(IRestClient restClient, OpenProjectContext context)
        {
            _restClient = restClient;
            _context = context;
        }

        public void Add<T>(T model) where T : class, new()
        {
            if (model == null)
                throw new Exception("Modelo Inválido!");

            _context.Add<T>(model);
            _context.SaveChanges();
        }

        public void Delete<T>(int id) where T : class, new()
        {
            var entity = _context.Find<T>(id);
            if (entity == null)
                throw new Exception("Entidade Inválida!");

            _context.Remove<T>(entity);
            _context.SaveChanges();
        }

        public IList<T> GetAll<T>() where T : class, new()
        {
            _context.Set<T>();
            var records = _context.Query<T>().ToList<T>();

            return records;
        }

        public IList<T> Select<T>(Expression<Func<T, bool>> expression) where T : class, new()
        {
            var set = _context.Set<T>();
            var models = set.AsQueryable().Where(expression);

            return models.ToList();
        }

        public void Update<T>(T model) where T : class, new()
        {
            _context.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.Update<T>(model);
            _context.SaveChanges();
        }
    }
}
