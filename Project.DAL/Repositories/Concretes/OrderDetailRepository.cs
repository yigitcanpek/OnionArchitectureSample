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
    public class OrderDetailRepository:BaseRepository<OrderDetail>,IOrderDetailRep
    {
        public OrderDetailRepository(MyContext db):base(db)
        {

        }
    }
}
