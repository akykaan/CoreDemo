using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using DataAcessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntityFramework
{
	public class EfCityRepository : GenericRepository<City>, ICityDal
	{
		public List<SelectListItem> GetAllCity()
		{
			using (Context db=new Context())
			{
				var result = (from c in db.Cities.ToList()
							 select new SelectListItem
							 {
								 Text = c.CityName,
								 Value = c.CityId.ToString()
							 }).ToList();
				return result;
			}
		}
	}
}
