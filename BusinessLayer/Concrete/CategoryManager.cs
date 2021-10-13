using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void CategoryAdd(Categories category)
		{
			_categoryDal.Insert(category);
		}

		public void CategoryDelete(Categories category)
		{
			_categoryDal.Delete(category);
		}

		public void CategoryUpdate(Categories category)
		{
			_categoryDal.Update(category);
		}

		public Categories GetById(int id)
		{
			return _categoryDal.GetByID(id);
		}

		public List<Categories> GetList()
		{
			return _categoryDal.GetListAll();
		}
	}
}
