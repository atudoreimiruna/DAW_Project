using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect1.DAL.Entities;

namespace Proiect1.DAL.Configurations
{
    public class DesignerCollectionConfiguration : IEntityTypeConfiguration<DesignerCollection>
    {
        public void Configure(EntityTypeBuilder<DesignerCollection> builder)
        {
            builder.HasOne(p => p.Designer)
                .WithMany(p => p.DesignerCollections)
                .HasForeignKey(p => p.DesignerId);

            builder.HasOne(p => p.Collection)
                .WithMany(p => p.DesignerCollections)
                .HasForeignKey(p => p.CollectionId);
        }
    }
}