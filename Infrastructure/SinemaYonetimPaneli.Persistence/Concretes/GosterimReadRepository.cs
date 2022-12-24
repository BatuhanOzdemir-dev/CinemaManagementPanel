using Microsoft.EntityFrameworkCore;
using SinemaYonetimPaneli.Application.Abstractions;
using SinemaYonetimPaneli.Domain.Entities;
using SinemaYonetimPaneli.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYonetimPaneli.Persistence.Concretes
{
    public class GosterimReadRepository : IGosterimReadRepository
    {
        private readonly SinemaYonetimPaneliDbContext _context;

        public GosterimReadRepository(SinemaYonetimPaneliDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Gosterim>> GetAllGosterimsAsync()
        {
            var entities = await _context.Gosterims.ToListAsync();
            if (entities != null)
            {
                return entities;
            }
            return null;
        }

        public async Task<IEnumerable<Gosterim>> GetAllGosterimsAsync(string salon)
        {
            var entities = await Task.Run(() => _context.Gosterims.Where(p => p.salon.salonAd == salon));
            if (entities != null)
            {
                return entities.ToList();
            }
            return null;
        }

        public async Task<IEnumerable<Gosterim>> GetGosterims(int year)
        {
            var entities = await Task.Run(() => _context.Gosterims.Where(p => p.gosterimYil == year));
            if (entities != null)
            {
                return entities.ToList();
            }
            return null;
        }

        public async Task<IEnumerable<Gosterim>> GetGosterims(int year1, int year2)
        {
            ChangeYears(year1, year2);
            var entities = await Task.Run(() => (_context.Gosterims.Where(p => (p.gosterimYil >= year1) & (p.gosterimYil <= year2))));
            if (entities != null)
            {
                return entities.ToList();
            }
            return null;
        }

        public async Task<IEnumerable<Gosterim>> GetGosterims(Salon salon)
        {
            var entities = await Task.Run(() => _context.Gosterims.Where(p => p.salon == salon));
            if (entities != null)
            {
                return entities.ToList();
            }
            return null;
        }

        public async Task<IEnumerable<Gosterim>> GetGosterims(Film film)
        {
            var entities = await Task.Run(() => _context.Gosterims.Where(p => p.film == film));
            if (entities != null)
            {
                return entities.ToList();
            }
            return null;
        }

        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(int year)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(int year1, int year2)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(Salon salon)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(string salon)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gosterim>> GetGosterimsAsync(Film film)
        {
            throw new NotImplementedException();
        }

        private void ChangeYears(int year1, int year2)
        {
            if (year1 > year2)
            {
                int temp = year1;
                year1 = year2;
                year2 = temp;
            }
        }
    }
}
