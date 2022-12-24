using Microsoft.EntityFrameworkCore;
using SinemaYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SinemaYonetimPaneli.Application.Abstractions
{
    public interface IFilmReadRepository
    {
        public Task<IEnumerable<Film>> GetFilmsAsync();
        public Task<Film> GetFilmAsync(int id);
        public Task<Film> GetFilmAsync(string film);
        public Task<IEnumerable<Film>> GetFilmsByYearAsync(int year);
        public Task<IEnumerable<Film>> GetFilmsByRangeAsync(int year1, int year2);
        public Task<SelectList> FilmSelectList();

    }
}
