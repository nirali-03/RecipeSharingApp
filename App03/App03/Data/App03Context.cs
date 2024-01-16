using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App03.Models;

namespace App03.Data
{
    public class App03Context : DbContext
    {
        internal readonly object Recipe;
       

        public App03Context (DbContextOptions<App03Context> options)
            : base(options)
        {
        }

        public DbSet<App03.Models.products> products { get; set; } 
        public DbSet<App03.Models.Register> Register { get; set; } 

        public DbSet<App03.Models.Post> Post { get; set; } = default!;

    }
}
