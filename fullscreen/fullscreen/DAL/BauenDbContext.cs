using fullscreen.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fullscreen.DAL
{
    public class BauenDbContext : IdentityDbContext<AppUser>
    {
        public BauenDbContext(DbContextOptions<BauenDbContext> options) : base(options) 
        { }

        public DbSet<Home> Homes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Projects> Projects { get; set; }
    }

    
}
