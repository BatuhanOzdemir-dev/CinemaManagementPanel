using SinemaYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYonetimPaneli.Application.Abstractions
{
    public interface IFilmWriteRepository
    {
        public Task<bool> AddFilmAsync(Film film);
        public Task<bool> RemoveFilmAsync(int id);
        public Task<bool> RemoveFilmAsync(Film film);
        public Task<bool> UpdateFilmAsync(Film film);
        public Task<int> SaveChangesAsync();
    }
}
