using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class categoryProductRepository : Repository<categoryProduct>, ICategoryProductRepository
    {
        private ApplicationDbContext _db;

        public categoryProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(categoryProduct obj)
        {
            _db.CategoryProducts.Update(obj);
        }
    }
}
