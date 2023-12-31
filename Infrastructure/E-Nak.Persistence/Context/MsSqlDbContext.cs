﻿using E_Nak.Domain.Entities.Account;
using E_Nak.Domain.Entities.Base;
using E_Nak.Domain.Entities.Transport;
using E_Nak.Domain.Entities.Vehicle;
using Microsoft.EntityFrameworkCore;

namespace E_Nak.Persistence.Context
{
    public class MsSqlDbContext : DbContext
    {

        #region Ctor
        public MsSqlDbContext(DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region Table

        public DbSet<Company> Companies { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<LoadType> LoadTypes { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

        public DbSet<PreliminaryOffers> PreliminaryOffers { get; set; }

        #endregion

        #region Interceptor

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker
                        .Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedAt = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedAt = DateTime.UtcNow,
                    EntityState.Deleted => data.Entity.DeletedAt = DateTime.UtcNow,

                };
                    
            }
                
                
            return base.SaveChangesAsync(cancellationToken);
        }
        #endregion

    }
}
