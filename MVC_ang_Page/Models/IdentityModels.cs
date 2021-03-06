﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MVC_ang_Page.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public override string Email { get; set; }

        public int Phno { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("MVC_ang_PageContext")
        {
        }

        public DbSet<ProductModels> Products { get; set; }

    }

}