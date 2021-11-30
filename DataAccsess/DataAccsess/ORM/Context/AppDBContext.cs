using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccsess.ORM.Entity;

namespace DataAccsess.ORM.Context
{
   public class AppDBContext:DbContext
    {
        public AppDBContext()
        {
            Database.Connection.ConnectionString = "server=LAPTOP-Q4TUCL3R\\SQLEXPRESS;Database=Filmdb;Trusted_Connection=True";
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Aktör> Aktörs { get; set; }
        public DbSet<Yönetmen> Yönetmens { get; set; }
    }
}
