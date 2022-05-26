using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karteikarten.Model;
namespace Karteikarten.Controller
{
    public class EFController : DbContext
    {
        public DbSet<karte> karte { get; set; }
        public DbSet<thema> thema { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite(@"data source = karteikartenDB.db");
        }
    }
}
