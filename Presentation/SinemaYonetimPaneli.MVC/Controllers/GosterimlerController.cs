using Microsoft.AspNetCore.Mvc;
using SinemaYonetimPaneli.Application.Abstractions;

namespace SinemaYonetimPaneli.MVC.Controllers
{
    public class GosterimlerController : Controller
    {
        private readonly IGosterimReadRepository _gosterimReadRepository;
        private readonly ISalonReadRepository _salonReadRepository;
        private readonly IFilmReadRepository _filmReadRepository;

        public GosterimlerController(IGosterimReadRepository gosterimReadRepository, ISalonReadRepository salonReadRepository, IFilmReadRepository filmReadRepository)
        {
            _gosterimReadRepository = gosterimReadRepository;
            _salonReadRepository = salonReadRepository;
            _filmReadRepository = filmReadRepository;
        }

        public async Task<IActionResult> All()
        {
            var gosterimler = await _gosterimReadRepository.GetAllGosterimsAsync();

            return View(gosterimler);

        }
        public async Task<IActionResult> AllInRange(int year1, int year2)
        {
            var gosterimler = await _gosterimReadRepository.GetGosterimsAsync(year1, year2);

            if (year1 == 0 || year2 == 0)
            {
                gosterimler = await _gosterimReadRepository.GetAllGosterimsAsync();
            }

            return View("All", gosterimler);
        }
        public async Task<IActionResult> AllInSalon(int salonID)
        {
            var _salon = await _salonReadRepository.GetSalonAsync(salonID);
            var gosterimler = await _gosterimReadRepository.GetGosterimsAsync(_salon);

            return View("All", gosterimler);
        }
        public async Task<IActionResult> AllWithMovie(int filmID)
        {
            var _film = await _filmReadRepository.GetFilmAsync(filmID);
            var gosterimler = await _gosterimReadRepository.GetGosterimsAsync(_film);

            return View("All", gosterimler);
        }
    }
}
