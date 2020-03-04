using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.DAL.Configurations.Base;
using NLayer.DAL.Entities;

namespace NLayer.DAL.Mappings
{
    public class DataConfiguration : EntityConfiguration<Data>
    {
        public DataConfiguration()
            : base(new ConfigurePropertiesDelegate(ConfigureProperties)) { }
        
        public static void ConfigureProperties(EntityTypeBuilder<Data> builder)
        {
            builder.Property(p => p.Name)
                   .HasMaxLength(100) 
                   .IsRequired();

            builder.Property(p => p.Description)
                   .HasMaxLength(1000);
        }
    }
}
