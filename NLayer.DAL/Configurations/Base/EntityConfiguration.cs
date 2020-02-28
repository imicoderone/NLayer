using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Abstractions.Entity;

namespace NLayer.DAL.Configurations.Base
{
    public class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        public delegate void ConfigurePropertiesDelegate(EntityTypeBuilder<T> builder);

        private readonly ConfigurePropertiesDelegate ConfigurePropertiesMethod;

        public EntityConfiguration(ConfigurePropertiesDelegate configureProperties)
        {
            ConfigurePropertiesMethod = configureProperties;
        }

        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            ConfigurePropertiesMethod(builder);
        }
    }
}
