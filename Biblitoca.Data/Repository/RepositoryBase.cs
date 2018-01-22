using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblitoca.Data.Repository
{
    public class RepositoryBase<TEntity> : IDisposable , IRepositoryBase<TEntity> where TEntity : class
    {

        public  BibliotecaContext bibliotecaContext = new BibliotecaContext();

        public void Add(TEntity obj)
        {
            bibliotecaContext.Set<TEntity>().Add(obj);
            bibliotecaContext.SaveChanges();
        }

        public void Dispose()
        {
            bibliotecaContext.Dispose();
        }

        public TEntity GetById(int id)
        {
            return bibliotecaContext.Set<TEntity>().Find(id);
        }

        public List<TEntity> ListAll()
        {
            return bibliotecaContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity obj)
        {
            bibliotecaContext.Set<TEntity>().Remove(obj);
            bibliotecaContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            bibliotecaContext.Entry<TEntity>(obj).State = System.Data.Entity.EntityState.Modified;
            bibliotecaContext.SaveChanges();
        }

        public void MarkStates( System.Data.Entity.EntityState state , params TEntity[] entity  )
        {
            foreach (var item in entity)
            {
                bibliotecaContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Unchanged;
            }
        }

    }
}
