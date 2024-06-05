using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NolanFlyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace NolanFlyApp.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=..\\..\\Data\\FlightTicketMaticDb.db");
        }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
