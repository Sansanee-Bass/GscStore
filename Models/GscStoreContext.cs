using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GscStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GscStore.Models
{
    public class GscStoreContext : IdentityDbContext
    {
        //public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<AdminUser> AdminUsers { get; set; } //
        public virtual DbSet<Product> Products { get; set; }
        public GscStoreContext(DbContextOptions<GscStoreContext> option)
            : base(option)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}


