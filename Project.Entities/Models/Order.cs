﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Order:BaseEntity
    {
        public string ShippedAddress { get; set; }
        public int? AppUserID { get; set; }

        public virtual AppUser AppUser { get; set; }
       
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
