using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{
			var values = bm.GetBlogListWithCategory();
			return View(values);
		}
		public IActionResult BlogReadAll(int id)
		{
			ViewBag.i = id;			
			var values = bm.GetBlogById(id);
			return View(values);
		}
		public IActionResult BlogListByWriter(int id)
		{
			var values=bm.GetBlogByWriter(2);
			return View(values);
		}

		[HttpGet]
		public IActionResult BlogAdd()
		{
			CategoryManager cm = new CategoryManager(new EfCategoryRepository());
			List<SelectListItem> categoryValues= (from x in cm.GetList()
												 select new SelectListItem
												 {
													 Text=x.CategoryName,
													 Value=x.CategoryId.ToString()
												 }).ToList();
			ViewBag.cv = categoryValues;
			return View();
		}

		[HttpPost]
		public IActionResult BlogAdd(Blog blog)
		{
			BlogValidator bv = new BlogValidator();
			ValidationResult result = bv.Validate(blog);

			if (result.IsValid)
			{
				blog.BlogStatus = true;
				blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				blog.WriterId=2;
				bm.TAdd(blog);
				return RedirectToAction("BlogListByWriter","Blog");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			CategoryManager cm = new CategoryManager(new EfCategoryRepository());
			List<SelectListItem> categoryValues = (from x in cm.GetList()
												   select new SelectListItem
												   {
													   Text = x.CategoryName,
													   Value = x.CategoryId.ToString()
												   }).ToList();
			ViewBag.cv = categoryValues;
			return View();
		}
	}
}
