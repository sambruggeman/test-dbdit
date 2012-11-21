using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbdit.DAL.Entities.Base;
using System.Data.Entity;

namespace dbdit.DAL.Repositories.Base
{
    public class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        private DbdItDbContext _context;
        private IDbSet<T> _entitySet;
        private bool _isDisposed;

        public RepositoryBase()
        {
            _context = new DbdItDbContext();
            _entitySet = _context.Set<T>();
        }

        public int Save(T entity)
        {
            if (entity.Id == 0)
            {
                _entitySet.Add(entity);
            }

            _context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(T entity)
        {
            _entitySet.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            T entity = Find(id);
            return Delete(entity);
        }

        public T Find(int id)
        {
            T entity = _entitySet.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public IQueryable<T> Get()
        {
            return _entitySet;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _context = null;
                _isDisposed = true;
            }
        }
    }
}
