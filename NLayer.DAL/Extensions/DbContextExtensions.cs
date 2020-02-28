using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NLayer.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using NLayer.Core.Extensions;

namespace NLayer.DAL.Extensions
{
    public static class DbContextExtensions
    {
        public static void SetAudit(this DbContext context)
        {
            context.SetAddedValues();
            context.SetModifiedValues();
        }

        public static void SetAddedValues(this DbContext context)
        {
            foreach (var entity in context.AddedAuditableEntities())
            {
                entity.Created();
            }
        }

        public static void SetModifiedValues(this DbContext context)
        {
            foreach (var entity in context.ModifiedAuditableEntities())
            {
                entity.Modified();
            }
        }

        public static void SetArchivedValues(this DbContext context)
        {
            foreach (var entry in context.DeletedArchivableEntries())
            {
                entry.Entity.Archive();
                entry.State = EntityState.Modified;
            }
        }

        public static IEnumerable<IAuditable> AddedAuditableEntities(this DbContext context)
        {
            return context.ChangeTracker.Entries<IAuditable>()
                                .Where(p => p.State == EntityState.Added)
                                .Select(p => p.Entity);
        }

        public static IEnumerable<IAuditable> ModifiedAuditableEntities(this DbContext context)
        {
            return context.ChangeTracker.Entries<IAuditable>()
                                .Where(p => p.State == EntityState.Modified)
                                .Select(p => p.Entity);
        }

        public static IEnumerable<EntityEntry<IArchivable>> DeletedArchivableEntries(this DbContext context)
        {
            return context.ChangeTracker.Entries<IArchivable>()
                                .Where(p => p.State == EntityState.Deleted);
        }
    }
}
