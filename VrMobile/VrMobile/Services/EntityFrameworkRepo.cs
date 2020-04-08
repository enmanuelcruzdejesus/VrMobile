using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using VrMobile.Models;
using Xamarin.Forms;
using XamCore.Services;
using Z.EntityFramework.Extensions;

namespace VrMobile.DAL.Services.Services
{
    public class EntityFrameworkRepo<TEntity>: IRepository<TEntity> where TEntity : class
    {
       
        DatabaseContext _dbContext;
        

        public EntityFrameworkRepo(DatabaseContext dbContext)
        {
            _dbContext = dbContext;

            EntityFrameworkManager.ContextFactory = context => new DbContextChild();


        }


        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public TEntity GetById(object id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate);
        }

        public IEnumerable<TEntity> GetLoadRerefence(string propertyName = null)
        {
            return _dbContext.Set<TEntity>().Include(propertyName).ToList();
        }

        public IEnumerable<TEntity> GetLoadRerefence(Expression<Func<TEntity, bool>> predicate, string propertyName =null)
        {
            return _dbContext.Set<TEntity>().Where(predicate).Include(propertyName).ToList();
        }

        public int Insert(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Insert(object entity)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            return _dbContext.SaveChanges();
        }

        public int Update(TEntity entity, Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return _dbContext.SaveChanges();
        }


        public object BulkInsert(IEnumerable<TEntity> entities)
        {
            
            _dbContext.BulkInsert<TEntity>(entities,options => options.IncludeGraph = true);
            _dbContext.BulkSaveChanges();
            return 1;
        }

        public object BulkMerge(IEnumerable<TEntity> entities)
        {

            var entity = entities.FirstOrDefault();

            if(entity is Customers)
            {
                _dbContext.BulkMerge<Customers>(entities, options =>
                 options.ColumnPrimaryKeyExpression = customer => customer.IdCustomer);

            }

            if (entity is Products)
            {
                _dbContext.BulkMerge<Products>(entities, options =>
                 options.ColumnPrimaryKeyExpression = product => product.IdProduct);

            }

            if (entity is Invoices)
            {

                _dbContext.BulkMerge<Invoices>(entities, options =>
                 options.ColumnPrimaryKeyExpression = invoice => invoice.IdInvoice);

            }

            if (entity is InvoiceDetails)
            {

                _dbContext.BulkMerge<InvoiceDetails>(entities, options =>
                 options.ColumnPrimaryKeyExpression = d => d.Id);

            }


            if (entity is VendorVisits)
            {

                _dbContext.BulkMerge<VendorVisits>(entities, options =>
                 options.ColumnPrimaryKeyExpression = visit => visit.IdVendorVisit);

            }

            if (entity is DeliveryOrders)
            {

                _dbContext.BulkMerge<DeliveryOrders>(entities, options =>
                 options.ColumnPrimaryKeyExpression = delivery => delivery.IdDelivery);

            }

      
            return 1;
        }

      
    }
}
