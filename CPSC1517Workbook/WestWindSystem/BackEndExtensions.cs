using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WestWindSystem.BLL;
using WestWindSystem.DAL;

namespace WestWindSystem
{
	public static class BackEndExtensions
	{
		public static void WWBackEndDependencies(this IServiceCollection services, Action<DbContextOptionsBuilder> options) 
		{
			// Register all the service taht the system provides
			services.AddDbContext<WestWindContext>(options);

			// Register services classes as transient services
			services.AddTransient<CustomerServices>((ServiceProvider) => 
			{ 
				var context = ServiceProvider.GetService<WestWindContext>();

				return new CustomerServices(context!);
			});

			services.AddTransient<CategoriesServices>((ServiceProvider) => 
			{
				var context = ServiceProvider.GetService<WestWindContext>();

				return new CategoriesServices(context!);
			});

			services.AddTransient<ProductServices>((ServiceProvider) =>
			{
				var context = ServiceProvider.GetService<WestWindContext>();

				return new ProductServices(context!);
			});
		}
	}
}
