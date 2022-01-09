using System;
using System.Collections.Generic;

namespace DataAccesLayer
{
    public interface IRepository<TEntity> where TEntity: class
    {
        public void Add(TEntity entity);

        public void Delete(TEntity entity);
         
        public List<TEntity> GetAll();

        public void Update(TEntity entity);

        public TEntity GetSingle(TEntity entity);

    }
}
