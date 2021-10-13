using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
	public class CommentList:ViewComponent
	{
		//çağır anlamına gelen invoke
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					ID=1,
					userName="kaan"
				},
				new UserComment
				{
					ID=2,
					userName="ozan"
				},
				new UserComment
				{
					ID=3,
					userName="emine"
				}
			};
			return View(commentValues);
		}
	}
}
