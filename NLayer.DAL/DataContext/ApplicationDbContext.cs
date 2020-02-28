using Microsoft.EntityFrameworkCore;
using NLayer.DAL.Extensions;
using NLayer.Core.Entities;
using NLayer.DAL.Mappings;
using System.Threading;
using System.Threading.Tasks;

namespace NLayer.DAL.DataContext
{
    public class ApplicationDbContext : DbContext, IDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Data> DataTable { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new DataConfiguration());
        }

        public override int SaveChanges()
        {
            this.SetAudit();
            this.SetArchivedValues();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            this.SetAudit();
            this.SetArchivedValues();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
