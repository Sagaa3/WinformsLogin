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
        string connection = "host=localhost; port=5432; database=EfcoreTestDb; user id=postgres; password=root";

        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connection);
        }
    }
}
