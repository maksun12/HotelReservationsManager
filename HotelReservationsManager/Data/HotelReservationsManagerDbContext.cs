using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservationsManager.Data
{
    public class HotelReservationsManagerDbContext : DbContext
    {
        const string connectionString = "Server=PC_11_303-PC\\SQLEXPRESS; Database=HotelReservationsManagerDB; Trusted_Connection=True";

   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
