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
    public class ProfileManager:BaseManager<AppUserProfile>,IProfileManager
    {
        IProfileRep _proRep;
        public ProfileManager(IProfileRep proRep):base(proRep)
        {
            _proRep = proRep;
        }
    }
}
