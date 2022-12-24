using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYonetimPaneli.Domain.Entities
{
    public class Gosterim
    {
        public int gosterimID { get; set; }
        public int gosterimYil { get; set; }
        public Film? film { get; set; }
        public Salon salon { get; set; }
    }
}
