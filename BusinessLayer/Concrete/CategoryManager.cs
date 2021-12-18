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
		public void TAdd(Categories t)
		{
			_categoryDal.Insert(t);
		}

		public void TDelete(Categories t)
		{
			_categoryDal.Delete(t);
		}

		public void TUpdate(Categories t)
		{
			_categoryDal.Update(t);
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