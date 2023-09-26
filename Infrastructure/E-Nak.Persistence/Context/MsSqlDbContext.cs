using E_Nak.Domain.Entities.Account;
using E_Nak.Domain.Entities.Transport;
using E_Nak.Domain.Entities.Vehicle;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Persistence.Context
{
    public class MsSqlDbContext : DbContext
    {

        #region Ctor
        public MsSqlDbContext(DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region Migration Table

        public DbSet<Company> Companies { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<LoadType> LoadTypes { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

        #endregion

    }
}
