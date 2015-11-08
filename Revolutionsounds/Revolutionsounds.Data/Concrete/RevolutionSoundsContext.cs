using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using Revolutionsounds.Entities.Abstract;
using Revolutionsounds.Entities.Data;

namespace Revolutionsounds.Data.Concrete
{
    public class RevolutionSoundsContext : DbContext
    {
        public RevolutionSoundsContext() : base("Name=RevolutionSoundsContext")
        {
        }

        public DbSet<Story> Stories { get; set; }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                            && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                var entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    var identityName = Thread.CurrentPrincipal.Identity.Name;
                    var now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
    }
}
