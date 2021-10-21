using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project.Entities.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.MAP.Configirations;

namespace Project.MAP.Configurations
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure (EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.AppUserProfile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.ID);

            //Bizim AppUser class'ımızın bizim yaptığımız property'lerin yanı sıra Microsoft'un Identity kütüphanesinden gelen property'leri de olacaktır...Identity'den gelen bu property'lerin icerisinde primary key olan ve Id ismine sahip olan bir property daha olacaktır...Dolayıısyla bu class tabloya cevrilirken hem bizim ID property'miz hem de Identity'den gönderdigi Id property'si Sql'daki Incasesensitive durum yüzünden aynı sütun sayılarak size migration durumunda bir tabloda aynı isimde iki sütun olamaz diye bir hata çıkaracaktır...Dolayısıyla bizim burada ID'miz C#'ta kalsa da onu (kendi ID'mizi) Sql'e göndermememiz gerekecektir...


            builder.Ignore(x => x.ID);


        }
    }
}


 