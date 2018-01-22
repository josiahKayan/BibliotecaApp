using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblitoca.Data.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {

        void Add(TEntity obj);
        void Remove(TEntity obj);

        void Update(TEntity obj);

        List<TEntity> ListAll();

        TEntity GetById( int id);

    }
}
