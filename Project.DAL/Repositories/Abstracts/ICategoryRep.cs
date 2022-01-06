using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Abstracts
{
    public interface ICategoryRep:IRepository<Category>
    {
        void SpecialCategoryCreation();
        void BaskaMetot();
    }
}
