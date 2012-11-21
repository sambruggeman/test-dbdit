using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbdit.DAL.Entities.Base;

namespace dbdit.DAL.Repositories
{
    public interface IRepository<T> : IDisposable where T : EntityBase
    {
        int Save(T entity);

        bool Delete(T entity);
        bool Delete(int id);

        T Find(int id);

        IQueryable<T> Get();
    }
}
