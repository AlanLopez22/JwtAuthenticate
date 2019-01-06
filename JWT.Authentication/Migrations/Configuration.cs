namespace JWT.Authentication.Migrations
{
    using JWT.Authentication.Data;
    using JWT.Authentication.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ApplicationDbContext.Create()));

            var user = new ApplicationUser()
            {
                UserName = "alopez",
                Email = "alan.lopez@mail.com",
                EmailConfirmed = true,
                FirstName = "Alan",
                LastName = "Lopez",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-1)
            };

            manager.Create(user, "P@ssword");
        }
    }
}
