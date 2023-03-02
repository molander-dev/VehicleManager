﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using VehicleManager.Models;
using VehicleManager.ViewModels;

namespace VehicleManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<VehicleManager.Models.Car> Cars { get; set; } = default!;
        public DbSet<VehicleManager.Models.VehicleCategory> VehicleCategories { get; set; } = default!;
        public DbSet<VehicleManager.Models.Rental> Rentals { get; set; } = default!;
        public DbSet<VehicleManager.Models.Customer> Customer { get; set; } = default!;
      

    }
}
                                       