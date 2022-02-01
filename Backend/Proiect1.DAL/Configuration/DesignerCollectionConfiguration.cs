using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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