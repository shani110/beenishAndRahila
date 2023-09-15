using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
	public class categoryProduct
	{
		public int Id { get; set; }
		public List<Category> cat { get; set;}
		public List<Product> pro { get; set;}
	}
}
