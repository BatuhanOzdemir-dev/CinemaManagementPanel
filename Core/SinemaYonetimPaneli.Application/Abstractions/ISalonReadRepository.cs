using SinemaYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SinemaYonetimPaneli.Application.Abstractions
{
    public interface ISalonReadRepository
    {
        public Task<IEnumerable<Salon>> GetSalonsAsync();
        public Task<Salon> GetSalonAsync(int id);
        public Task<Salon> GetSalonAsync(string salon);
        public Task<SelectList> SalonSelectList();

    }
}
