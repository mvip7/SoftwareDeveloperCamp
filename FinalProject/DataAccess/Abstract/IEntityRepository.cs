using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constrain => t için kısıtlama işlemi
    // buradaki class => referans tipi
    // IEntity => IEntity veya IEntity implementine Sahip bir başka nesne olabilir
    // new() => sadece new'lenebilen nesne olmalı. interfaceler newlenemez
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
