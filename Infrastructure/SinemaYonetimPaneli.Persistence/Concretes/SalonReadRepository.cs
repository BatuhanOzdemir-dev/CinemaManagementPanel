using Microsoft.EntityFrameworkCore;
using SinemaYonetimPaneli.Application.Abstractions;
using SinemaYonetimPaneli.Domain.Entities;
using SinemaYonetimPaneli.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SinemaYonetimPaneli.Persistence.Concretes
{
    public class SalonReadRepository : ISalonReadRepository
    {
        private readonly SinemaYonetimPaneliDbContext _context;

        public SalonReadRepository(SinemaYonetimPaneliDbContext context)
        {
            _context = context;
        }
        public async Task<SelectList> SalonSelectList()
        {
            var items = await GetSalonsAsync();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (Salon s in items)
            {
                list.Add(new SelectListItem { Text = s.salonAd, Value = s.salonID.ToString(), Selected = true });
            }
            SelectList list2 = new SelectList(list, _context.Salons.FirstOrDefault().salonID);
            return list2;
        }

        public async Task<Salon> GetSalonAsync(int id)
        {
            var entity = await _context.Salons.FindAsync(id);
            return entity;
        }

        public async Task<Salon> GetSalonAsync(string salon)
        {
            var entity = await _context.Salons.FirstOrDefaultAsync(s => s.salonAd == salon);
            return entity;
        }

        public async Task<IEnumerable<Salon>> GetSalonsAsync()
        {
            var entities = await _context.Salons.ToListAsync();
            return entities;
        }
    }
}
