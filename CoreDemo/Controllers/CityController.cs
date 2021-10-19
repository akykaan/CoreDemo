using BusinessLayer.Concrete;
using DataAcessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class CityController : Controller
	{
		CityManager c = new CityManager(new EfCityRepository());
		Context db = new Context();
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult GetAll()
		{
;			ViewBag.cities = c.GetAllCity();
			var values = ViewBag.cities;
			return View(values);
		}
	}
}
