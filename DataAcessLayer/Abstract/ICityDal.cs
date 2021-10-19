using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
	public interface ICityDal: IGenericDal<City>
	{
		List<SelectListItem> GetAllCity();
	}
}
