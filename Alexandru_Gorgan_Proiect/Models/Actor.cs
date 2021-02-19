using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexandru_Gorgan_Proiect.Models
{
    public class Actor
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public int FilmID { get; set; }
        public Movie Film { get; set; } // navigation property
    }
}
