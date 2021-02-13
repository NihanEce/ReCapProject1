﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic Constraint
    //class: referans tip olabilir
    //IEntity:IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new(); newlenebilir olmalı. Ientity yi de harcadık
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        //List<T> GetById(); GetByID de List olmaz!!!! T GetById olmalı burası
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
