using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect1.DAL.Entities;

namespace Proiect1.DAL.Configurations
{
    public class DesignerClientConfiguration : IEntityTypeConfiguration<DesignerClient>
    {
        public void Configure(EntityTypeBuilder<DesignerClient> builder)
        {
            builder.HasOne(p => p.Designer)
                .WithMany(p => p.DesignerClients)
                .HasForeignKey(p => p.DesignerId);

            builder.HasOne(p => p.Client)
                .WithMany(p => p.DesignerClients)
                .HasForeignKey(p => p.ClientId);
        }
    }
}
