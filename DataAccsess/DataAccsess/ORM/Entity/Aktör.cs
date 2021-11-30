using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.ORM.Entity
{
   public class Aktör:BaseClass 
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public List<Film> Films { get; set; }
    }
}
