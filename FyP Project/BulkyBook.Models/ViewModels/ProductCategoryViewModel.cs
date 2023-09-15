using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models.ViewModels
{
	// ViewModel for the view
	public class ProductCategoryViewModel
	{
		public IEnumerable<Product> Products { get; set; }
		public IEnumerable<Category> Categories { get; set; }
	}

}
