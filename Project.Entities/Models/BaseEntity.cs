using Project.Entities.CoreInterfaces;
using Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public abstract class BaseEntity:IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }


        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            CreatedDate = DateTime.Now;
        }

    }
}

