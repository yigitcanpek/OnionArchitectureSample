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
    public class OrderManager:BaseManager<Order>,IOrderManager
    {
        IOrderRep _orderRep;

        public OrderManager(IOrderRep orderRep) : base(orderRep)
        {
            _orderRep = orderRep;
        }
    }
}
