using DependencyInjectionOdev.Cinema.DataAccess.Concrete.EntityFramework.Maps.Concrete;
using DependencyInjectionOdev.Cinema.Entities.ComplexType;
using DependencyInjectionOdev.Cinema.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.DataAccess.Concrete.EntityFramework.Context
{
    public class CinemaContext: IdentityDbContext<IdentityUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CHSJJ4J\\SQLEXPRESS;database=CinemaDB;Trusted_Connection=true;");
        }

        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MovieMap());
            base.OnModelCreating(builder);
        }

    }
}
