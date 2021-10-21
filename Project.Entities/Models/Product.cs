using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Product:BaseEntity
    {
        public string Productname { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
