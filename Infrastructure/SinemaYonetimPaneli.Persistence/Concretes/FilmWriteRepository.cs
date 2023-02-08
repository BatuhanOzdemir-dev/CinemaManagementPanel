using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class FilmWriteRepository : IFilmWriteRepository
    {
        private readonly SinemaYonetimPaneliDbContext _context;

        public FilmWriteRepository(SinemaYonetimPaneliDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddFilmAsync(Film film)
        {
            EntityEntry entityEntry = await _context.AddAsync(film);
            return entityEntry?.State == EntityState.Added;
        }

        public async Task<bool> RemoveFilmAsync(int id)
        {
            EntityEntry entityEntry = await Task.Run(() => _context.Remove(
                _context.Films.FirstOrDefaultAsync(p => p.filmID == id)));
            return entityEntry?.State == EntityState.Deleted;
        }
        public async Task<bool> RemoveFilmAsync(Film film)
        {
            EntityEntry entityEntry = await Task.Run(() => _context.Remove(film));
            return entityEntry?.State == EntityState.Deleted;
        }

        public async Task<bool> UpdateFilmAsync(Film film)
        {
            EntityEntry entityEntry = await Task.Run(() => _context.Update(film));
            return entityEntry?.State == EntityState.Modified;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
