using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager nlm = new NewsLetterManager(new EfNewsLetterRepository());

		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}

		[HttpPost]
		public JsonResult SubscribeMail(NewsLetter newsLetter)
		{
			newsLetter.MailStatus = true;
			nlm.AddNewsLetter(newsLetter);

			return Json(new
			{
				status = "Success",
				newsletter = newsLetter,
				message = "Mail Başarı ile eklendi",
				errorMessage = "Hata oluştu. Mail eklenemedi.",
			});
		}
	}
}
