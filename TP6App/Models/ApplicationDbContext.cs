using System.Collections.Generic;
using System.Reflection.Emit;
using TP6App.Models;
using Microsoft.EntityFrameworkCore;
namespace TP6App.Models

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        // Ajout des DbSet pour mapper les entités avec les tables de la base de données.
        public DbSet<WeatherForecast>? WeatherForecast { get; set; }
       

       

    }
}
