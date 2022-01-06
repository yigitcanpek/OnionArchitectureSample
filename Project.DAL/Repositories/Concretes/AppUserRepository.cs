using Microsoft.AspNetCore.Identity;
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
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRep
    {
        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;

        public AppUserRepository(MyContext db,UserManager<AppUser> userManager,SignInManager<AppUser> signInManager):base(db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> AddUser(AppUser item)
        {
            //Sadece Asenkron olarak yaratılmıs (async marklı) metotlar icerisinde await kullanabilirsiniz...Ve Api Requestlerinin bloklanmaması için await kullanmalısınız

            IdentityResult result = await _userManager.CreateAsync(item, item.PasswordHash);
            if(result.Succeeded)
            {
                await _signInManager.SignInAsync(item, isPersistent: false);//isPersisten durumu Cookie'de dursun mu durmasın mıS
            }
            return false;
        }
    }
}
