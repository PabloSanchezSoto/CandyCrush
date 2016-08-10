﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using MvcCandyCrush.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartup(typeof(MvcCandyCrush.Startup))]

namespace MvcCandyCrush
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}



//namespace MvcCandyCrush
//{
//    public partial class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            ConfigureAuth(app);
//            createRolesandUsers();
//        }

//        private void createRolesandUsers()
//        {
//            ApplicationDbContext context = new ApplicationDbContext();

//            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
//            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

//            // In Startup iam creating first Admin Role and creating a default Admin User    
//            if (!roleManager.RoleExists("Admin"))
//            {

//                // first we create Admin rool   
//                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
//                role.Name = "Admin";
//                roleManager.Create(role);

//                //Here we create a Admin super user who will maintain the website                  
//                var user = new ApplicationUser();
//                user.UserName = "jPablo";
//                user.Email = "josepablosanchezsoto@gmail.com";

//                string userPWD = "Asdf1234!";

//                var chkUser = UserManager.Create(user, userPWD);

//                //Add default User to Role Admin   
//                if (chkUser.Succeeded)
//                {
//                    var result1 = UserManager.AddToRole(user.Id, "Admin");

//                }
//            }
//            // creating Creating Manager role    
//            if (!roleManager.RoleExists("Usuario"))
//            {
//                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
//                role.Name = "Usuario";
//                roleManager.Create(role);

//            }
//        }
//    }