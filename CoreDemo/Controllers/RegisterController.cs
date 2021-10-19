using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAcessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		Context db = new Context();

		ICityService _cityService;

		public RegisterController(ICityService cityService)
		{
			_cityService = cityService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var cities = _cityService.GetAllCity();
			if (cities != null)
			{
				ViewBag.cities = cities;
				return View();
			}
			else
			{
				ViewBag.cities = "yok";
				return View();
			}
			//List<SelectListItem> cities =
			//	(from i in db.Cities.ToList()
			//	 select new SelectListItem
			//	 {
			//		 Text = i.CityName,
			//		 Value = i.CityId.ToString()
			//	 }).ToList();
			//ViewBag.cities = cities;
		}

		[HttpPost]
		public IActionResult Index(Writer p,City city)
		{
			p.WriterStatus = true;
			p.WriterAbout = "deneme test";
			p.CityId = city.CityId;
			wm.WriterAdd(p);

			return RedirectToAction("Index","Blog");
		}
	}
}
