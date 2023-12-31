﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Required namespaces
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
	public class ProductServices
	{
		private readonly WestWindContext _context;

		internal ProductServices(WestWindContext context) { _context = context; }

		public List<Product> GetAllProductsInSelectedCategory(int id)
		{
			return _context.Products.Where(p => p.CategoryId == id).ToList();
		}
	}
}
