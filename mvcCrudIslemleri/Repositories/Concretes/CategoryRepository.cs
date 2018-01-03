using mvcCrudIslemleri.Data.Entities;
using mvcCrudIslemleri.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using mvcCrudIslemleri.Repositories.Abstracts;

namespace mvcCrudIslemleri.Repositories.Concretes
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}