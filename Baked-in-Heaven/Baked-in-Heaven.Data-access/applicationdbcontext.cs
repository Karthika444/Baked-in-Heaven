
using Baked_in_Heaven.Data_access.Entities;
using Baked_in_Heaven.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baked_in_Heaven.Data_access
{
    public class applicationdbcontext : DbContext

    {
        public applicationdbcontext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=localhost;Database=BakedInHeavenDb;Username=postgres;Password=Karthu@123";
            optionsBuilder.UseNpgsql(connectionString);

        }



        }
    }
