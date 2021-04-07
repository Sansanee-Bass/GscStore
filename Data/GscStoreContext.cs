using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GscStore.Models;

    public class GscStoreContext : DbContext
    {
        public GscStoreContext (DbContextOptions<GscStoreContext> options)
            : base(options)
        {
        }

        public DbSet<GscStore.Models.Product> Product { get; set; }
    }
