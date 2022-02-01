using Proiect1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Configurations
{
    public class CollectionFactoryConfiguration : IEntityTypeConfiguration<CollectionFactory>
    {
        public void Configure(EntityTypeBuilder<CollectionFactory> builder)
        {
            builder.Property(p => p.FactoryName)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(p => p.FactoryAddress)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);
        }
    }
}