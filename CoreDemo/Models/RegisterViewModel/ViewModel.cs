using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models.RegisterViewModel
{
	public class ViewModel
	{
		public Writer Writers { get; set; }
		public List<SelectListItem> Cities { get; set; }
	}
}
