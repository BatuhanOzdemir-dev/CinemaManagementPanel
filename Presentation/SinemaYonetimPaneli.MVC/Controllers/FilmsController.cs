using Microsoft.AspNetCore.Mvc;
using SinemaYonetimPaneli.Application.Abstractions;
using SinemaYonetimPaneli.Domain.Entities;
using SinemaYonetimPaneli.Persistence;
using System.Collections.Generic;

namespace SinemaYonetimPaneli.MVC.Controllers
{
    public class FilmsController : Controller
    {
        private readonly IFilmReadRepository _filmReadRepository;
        private readonly IFilmWriteRepository _filmWriteRepository;

        public FilmsController(IFilmReadRepository filmReadRepository, IFilmWriteRepository filmWriteRepository)
        {
            _filmReadRepository = filmReadRepository;
            _filmWriteRepository = filmWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var films = await _filmReadRepository.GetFilmsAsync();
            return View(films);
        }
        [HttpGet]
        public async Task<IActionResult> AllInRange(int year1, int year2)
        {
            var films = await _filmReadRepository.GetFilmsByRangeAsync(year1, year2);

            if (year1 == 0 || year2 == 0)
            {
                films = await _filmReadRepository.GetFilmsAsync();
            }

            return View("All", films);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Film film)
        {
            await _filmWriteRepository.AddFilmAsync(film);
            await _filmWriteRepository.SaveChangesAsync();
            return View(film);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Film film = await _filmReadRepository.GetFilmAsync(id);
            return View(film);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(Film film)
        {
            await _filmWriteRepository.RemoveFilmAsync(film);
            await _filmWriteRepository.SaveChangesAsync();
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Film film = await _filmReadRepository.GetFilmAsync(id);
            return View(film);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Film film)
        {
            await _filmWriteRepository.UpdateFilmAsync(film);
            await _filmWriteRepository.SaveChangesAsync();
            return View(film);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            Film film = await _filmReadRepository.GetFilmAsync(id);
            return View(film);
        }
    }
}
