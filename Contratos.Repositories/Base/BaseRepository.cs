using Contratos.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Contratos.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ContratosContexto _context = null;
        protected readonly DbSet<TEntity> entidade;
        private bool _disposed;

        public BaseRepository(ContratosContexto context)
        {
            _context = context;
            entidade = _context.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            entidade.Add(obj);
        }

        public void Add(List<TEntity> obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TEntity obj)
        {
            throw new System.NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed && disposing)
            {
                _context.Dispose();
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public TEntity GetById(int id)
        {
            return entidade.Find(id);
        }

        public IEnumerable<TEntity> Listar(Expression<Func<TEntity, bool>> predicate)
        {
            return entidade.Where(predicate);
        }

        public IEnumerable<TEntity> Listar()
        {
            return entidade.ToList();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
