using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYonetimPaneli.Domain.Entities
{
    public class Film
    {
        public int filmID { get; set; }
        public string filmAd { get; set;}
        public string filmYapimYil { get; set; }
        public ICollection<Gosterim>? gosterims { get; set; }
    }
}
