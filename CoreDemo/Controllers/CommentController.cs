using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		
		[HttpPost]
		public JsonResult PartialAddComment(Comment comment)
		{
			comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.CommentStatus = true;
			comment.BlogId = 2;
			cm.CommentAdd(comment);
			return Json(new
			{
				status = "Success",
				comment = comment,
				message = "Yorum Başarı ile eklendi",
				errorMessage = "Hata oluştu. Yorum eklenemedi.",
			});
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values=cm.GetList(id);
			return PartialView(values);
		}
	}
}
