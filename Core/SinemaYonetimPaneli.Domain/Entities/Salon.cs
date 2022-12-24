using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYonetimPaneli.Domain.Entities
{
    public class Salon
    {
        public int salonID { get; set; }
        public string salonAd { get; set; }
        public ICollection<Gosterim>? gosterims { get; set; }
    }
}
