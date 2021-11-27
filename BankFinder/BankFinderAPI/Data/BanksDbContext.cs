using BankFinderAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankFinderAPI.Data
{
    public class BanksDbContext : DbContext
    {
        public BanksDbContext(DbContextOptions<BanksDbContext> options) : base(options)
        {

        }

        public DbSet<Address> Address { get; set; }
        public DbSet<BicCode> BicCode { get; set; }
        public DbSet<SortCode> SortCode { get; set; }
        public DbSet<FaxNumber> FaxNumber { get; set; }
        public DbSet<OpeningHours> OpeningHours { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Institution> Institution { get; set; }
    }
}
