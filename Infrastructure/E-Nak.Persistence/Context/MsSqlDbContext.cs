using E_Nak.Domain.Common;
using E_Nak.Domain.Entities.Account;
using E_Nak.Domain.Entities.Datas.Transport;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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

        #region Account
        public DbSet<Company> Producers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        #endregion

        #region Datas
        //public DbSet<Transport> Transports { get; set; }

        #endregion


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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

    }
}
