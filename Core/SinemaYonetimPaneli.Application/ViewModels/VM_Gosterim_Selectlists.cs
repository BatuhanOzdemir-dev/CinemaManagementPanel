using SinemaYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SinemaYonetimPaneli.Application.ViewModels
{
    public class VM_Gosterim_Selectlists
    {
        public IEnumerable<Gosterim> Gosterimler;
        public SelectList SalonSelectList;
        public SelectList FilmSelectList;
        public int FilmId;
        public int SalonId;
    }
}
