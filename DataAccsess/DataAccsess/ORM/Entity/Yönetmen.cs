using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.ORM.Entity
{
   public class Yönetmen:BaseClass
    {
        public string Adı { get; set; }

        public string Soyadı { get; set; }

        public List<Film> Films { get; set; }
    }
}
