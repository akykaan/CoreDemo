using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.City
{
	public class CityList:ViewComponent
	{
		CityManager cm = new CityManager(new EfCityRepository());


		public IViewComponentResult Invoke()
		{
			var values = cm.GetAllCity();
			ViewBag.cities = values;
			return View();
		}
	}
}
