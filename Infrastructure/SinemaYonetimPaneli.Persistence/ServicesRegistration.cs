using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SinemaYonetimPaneli.Application.Abstractions;
using SinemaYonetimPaneli.Persistence.Concretes;
using SinemaYonetimPaneli.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYonetimPaneli.Persistence
{
    public static class ServicesRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SinemaYonetimPaneliDbContext>(options
                => options.UseSqlServer(connectionString));
            services.AddScoped<IFilmReadRepository, FilmReadRepository>();
            services.AddScoped<IFilmWriteRepository, FilmWriteRepository>();
            services.AddScoped<IGosterimReadRepository, GosterimReadRepository>();
            services.AddScoped<ISalonReadRepository, SalonReadRepository>();

        }
    }
}
