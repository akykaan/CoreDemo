using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models.RegisterViewModel;
using DataAcessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
		//WriterManager wm = new WriterManager(new EfWriterRepository());
		//Context db = new Context();

		ICityService _cityService;
		IWriterService _writerService;

		public RegisterController(ICityService cityService, IWriterService writerService)
		{
			_cityService = cityService;
			_writerService = writerService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			//ViewModel vm = new ViewModel();

			//vm.Cities = _cityService.GetAllCity();

			//var cities = vm.Cities;
			//if (cities != null)
			//{
			//	ViewBag.cities = cities;
			//	return View();
			//}
			//else
			//{
			//	ViewBag.cities = "yok";
			//	return View();
			//}

			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer p,City city)
		{
			WriterValidator wV = new WriterValidator();
			ValidationResult result = wV.Validate(p);

			if (result.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "deneme test";
				p.CityId = city.CityId;
				//wm.WriterAdd(p);
				_writerService.WriterAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			var cities = _cityService.GetAllCity();
			ViewBag.cities=cities;
			return View();
		}
	}
}
