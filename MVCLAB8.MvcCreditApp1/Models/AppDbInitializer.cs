using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCLAB8.MvcCreditApp1.Models
{
    public class AppDbInitializer :
        DropCreateDatabaseAlways<ApplicationDbContext>
    {
        //Переопределите метод Seed(), в котором создайте объекты
        //UserManager и RoleManager с помощью контекста данных для управления пользователями и ролями:
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //Далее создайте две роли с именами admin и user:
            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };
            //Добавьте роли в базу данных:
            roleManager.Create(role1);
            roleManager.Create(role2);
            //Создайте пользователя-администратора с указанием советующих параметров:
            var admin = new ApplicationUser { Email = "admin@mail.ru", UserName = "admin@mail.ru" };
            string password = "qwerty_311";
            var result = userManager.Create(admin, password);
            //В случае успешного создания пользователя-администратора добавьте для него роли:
            if (result.Succeeded)
            {
                userManager.AddToRole(admin.Id, role1.Name);
                userManager.AddToRole(admin.Id, role2.Name);
            }
            base.Seed(context);
        }
    }
}