using E_Nak.Domain.Common;
using E_Nak.Domain.Entities.Account;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Security.Claims;

namespace E_Nak.Persistence.Context
{
    public class ENakDbContext : IdentityDbContext<User, Role, string>
    {

        #region Fields & Ctor

        public ENakDbContext(DbContextOptions options) : base(options)
        {
        }

        #endregion

        #region Table


        #endregion

        #region Defination Table 


        #endregion

        #region Method

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #endregion

        #region Interceptor

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            var entriesGuid = ChangeTracker
                 .Entries<BaseEntity<Guid>>();

            foreach (var data in entriesGuid)
            {


                if (data.State == EntityState.Added)
                {
                    data.Entity.CreatedAt = DateTime.UtcNow;
                    //data.Entity.CreatedBy = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
                }
                else if (data.State == EntityState.Modified)
                {
                    data.Entity.UpdatedAt = DateTime.UtcNow;
                    //data.Entity.UpdatedBy = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
                }
                else if (data.State == EntityState.Deleted)
                {
                    data.Entity.DeletedAt = DateTime.UtcNow;
                    //data.Entity.DeletedBy = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
                    data.Entity.IsActive = false;
                    data.State = EntityState.Modified;
                }

                //_ = data.State switch
                //{
                //    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                //    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
                //    EntityState.Deleted => data.Entity.DeletedDate = DateTime.Now,
                //    _ => DateTime.Now
                //};

            }

            // INT türündeki varlıklar için işlemler
            var intEntities = ChangeTracker
                .Entries<BaseEntity<int>>();

            foreach (var entity in intEntities)
            {

                if (entity.State == EntityState.Added)
                {
                    entity.Entity.CreatedAt = DateTime.UtcNow;
                    //entity.Entity.CreatedBy = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
                }
                else if (entity.State == EntityState.Modified)
                {
                    entity.Entity.UpdatedAt = DateTime.UtcNow;
                    //data.Entity.UpdatedBy = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
                }
                else if (entity.State == EntityState.Deleted)
                {
                    entity.Entity.DeletedAt = DateTime.UtcNow;
                    //data.Entity.DeletedBy = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
                    entity.Entity.IsActive = false;
                    entity.State = EntityState.Modified;
                }

                //_ = entity.State switch
                //{
                //    EntityState.Added => entity.Entity.CreatedDate = DateTime.Now,
                //    EntityState.Modified => entity.Entity.UpdatedDate = DateTime.Now,
                //    EntityState.Deleted => entity.Entity.DeletedDate = DateTime.Now,
                //    _ => DateTime.Now
                //};
            }

            return await base.SaveChangesAsync(cancellationToken);


        }

        #endregion


    }
}
