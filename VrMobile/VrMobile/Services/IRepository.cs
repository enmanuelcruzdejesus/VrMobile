﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace XamCore.Services
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetLoadRerefence(string propertyName = null);


        IEnumerable<TEntity> GetLoadRerefence(Expression<Func<TEntity, bool>> predicate, string propertyName =null);



        TEntity GetById(object id);


        int Update(TEntity entity);

        int Update(TEntity entity, Expression<Func<TEntity, bool>> predicate);

        int Insert(TEntity entity);

        int Insert(object entity);


        int Delete(TEntity entity);




        object BulkInsert(IEnumerable<TEntity> entities);

        object BulkMerge(IEnumerable<TEntity> entities);









    }
}