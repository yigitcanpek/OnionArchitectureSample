﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using Project.MAP.Configirations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class OrderDetailConfiguration:BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.ToTable("Satıslar");
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
        }
    }
}
