using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using YazilimGerceklemeTest.Models;

namespace YazilimGerceklemeMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Arac> Araclar { get; set; }
    }
}
