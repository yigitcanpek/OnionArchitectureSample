using Project.BLL.ManagerServices.Abstracts;
using Project.Entities.Models;
using Project.DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class AppUserManager:BaseManager<AppUser>,IAppUserManager
    {
        IAppUserRep _appRep;
        public AppUserManager (IAppUserRep appRep) : base(appRep)
        {
            _appRep = appRep;
        }
    }
}
