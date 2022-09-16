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
    public class OrderDetailManager:BaseManager<OrderDetail>,IOrderDetailManager
    {
        IOrderDetailRep _ordeRep;
         public OrderDetailManager(IOrderDetailRep ordeRep):base(ordeRep)
        {
            _ordeRep = ordeRep;
        }
    }
}
