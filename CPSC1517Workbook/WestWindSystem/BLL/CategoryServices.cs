using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Required namespaces
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
	public class CategoriesServices
	{
		private readonly WestWindContext _context;

		internal CategoriesServices(WestWindContext context) { _context = context; }

		public List<Category> GetAllCategories()
		{
			return _context.Categories.ToList<Category>();
		}
	}
}
