﻿using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CategoryManager : ICategoryService//cagetroyle ılgılı şsleri yoneticegiz.
    {

        ICategoryDal _categoryDal;


        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(x=>x.CategoryID==categoryId);

        }
    }

}
