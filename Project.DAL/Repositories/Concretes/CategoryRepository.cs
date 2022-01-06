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
    public class CategoryRepository : BaseRepository<Category>, ICategoryRep
    {
        public CategoryRepository(MyContext db):base(db)
        {

        }
        public void BaskaMetot()
        {
            throw new NotImplementedException();
        }

        public void SpecialCategoryCreation()
        {
            throw new NotImplementedException();
        }
    }
}
