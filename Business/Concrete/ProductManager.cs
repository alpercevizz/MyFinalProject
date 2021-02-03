﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public List<Product> GetAll()
        {
            // Business codes

            //InMemoryProductDal ınMemoryProductDal = new InMemoryProductDal(); -> Executed with storage. A one class don't new another classes.
            return _ProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _ProductDal.GetAll(p=>p.CategoryID==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _ProductDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max); 
        }
    }
}
