using Microsoft.EntityFrameworkCore;
using SinemaYonetimPaneli.Application.Abstractions;
using SinemaYonetimPaneli.Domain.Entities;
using SinemaYonetimPaneli.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SinemaYonetimPaneli.Persistence.Concretes
{
    public class FilmReadRepository : IFilmReadRepository
    {
        private readonly SinemaYonetimPaneliDbContext _context;

        public FilmReadRepository(SinemaYonetimPaneliDbContext context)
        {
            _context = context;
        }

        public async Task<SelectList> FilmSelectList()
        {
            var items = await GetFilmsAsync();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (Film f in items)
            {
                list.Add(new SelectListItem { Text = f.filmAd, Value = f.filmID.ToString(), Selected = true });
            }
            SelectList list2 = new SelectList(list, _context.Films.FirstOrDefault().filmID);
            return list2;
        }
        public async Task<Film> GetFilmAsync(int id)
        {
            var entity = await _context.Films.FindAsync(id);
            return entity;
        }
        public async Task<Film> GetFilmAsync(string film)
        {
            var entity = await _context.Films.FirstOrDefaultAsync(f => f.filmAd == film);
            return entity;
        }

        public async Task<IEnumerable<Film>> GetFilmsAsync()
        {
            var entities = await _context.Films.ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<Film>> GetFilmsByRangeAsync(int year1, int year2)
        {
            ChangeYears(year1, year2);
            var entities = await Task.Run(() => (_context.Films.Where(p => (p.filmYapimYil >= year1) & (p.filmYapimYil <= year2))));
            return entities;
        }

        public async Task<IEnumerable<Film>> GetFilmsByYearAsync(int year)
        {
            var entities = await Task.Run(() => _context.Films.Where(p => p.filmYapimYil == year));
            return entities;
        }

        private void ChangeYears(int year1, int year2)
        {
            if(year1 > year2)
            {
                int temp = year1;
                year1 = year2;
                year2 = temp;
            }
        }
    }
}
