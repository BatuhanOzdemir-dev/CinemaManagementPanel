using SinemaYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYonetimPaneli.Application.Abstractions
{
    public interface IGosterimReadRepository
    {
        public Task<IEnumerable<Gosterim>> GetAllGosterimsAsync();
        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(int year);
        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(int year1, int year2);
        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(Salon salon);
        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(string salon);
        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(Film film);

    }
}
