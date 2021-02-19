using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexandru_Gorgan_Proiect.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public decimal Rating { get; set; }

        public ICollection<Cinema> Cinemas { get; set; }
    }
}
