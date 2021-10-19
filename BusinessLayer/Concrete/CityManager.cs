using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CityManager : ICityService
	{
		ICityDal _cityDal;
		public CityManager(ICityDal cityDal)
		{
			_cityDal = cityDal;
		}

		public List<SelectListItem> GetAllCity()
		{
			return _cityDal.GetAllCity();
		}
	}
}
