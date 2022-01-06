using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class ProductRepository:BaseRepository<Product>,IProductRep
    {
        public ProductRepository(MyContext db):base(db)
        {

        }
    }
}
