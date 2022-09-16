using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class CategoryManager:BaseManager<Category>,ICategoryManager
    {
        ICategoryRep _catRep;
        public CategoryManager(ICategoryRep catRep):base(catRep)
        {
            _catRep = catRep;
        }
        public override string Add(Category item)
        {
            if (item.Name != null)
            {
                _catRep.Add(item);
                return "Kategori eklendi";
            }
            return "Kategori ismi girilmemiş";
           
        }
    }
}
