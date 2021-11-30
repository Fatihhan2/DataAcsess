using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.ORM.Entity
{
   public class Film:BaseClass
    {
        public string FilmAdı { get; set; }

        public DateTime VizyonTarihi { get; set; }

        public int Puan { get; set; }

        public decimal Hasılat { get; set; }

        public string Afiş { get; set; }


        public int YönetmenId { get; set; }
        public Yönetmen Yönetmen { get; set; }
        public List<Aktör> Aktörs { get; set; }

    }
}
