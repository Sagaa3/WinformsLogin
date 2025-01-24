using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsLogin.Model;

namespace WinformsLogin
{
    internal class contex : DbContext
    {
        string connection = "host=localhost; port=5432; database=winformdb; user id=postgres; password=root";

        public contex()
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connection);
        }
    }
}
