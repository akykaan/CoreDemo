using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICategoryService
	{
		void CategoryAdd(Categories category);
		void CategoryDelete(Categories category);
		void CategoryUpdate(Categories category);
		List<Categories> GetList();
		Categories GetById(int id);
	}
}
