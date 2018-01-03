using mvcCrudIslemleri.Data.Entities;
using mvcCrudIslemleri.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcCrudIslemleri.Repositories.Concretes
{
    public class ProductRepository: RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {


        }
    }
}