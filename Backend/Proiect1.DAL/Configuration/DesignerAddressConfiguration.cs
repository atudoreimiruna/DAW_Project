using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect1.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Configurations
{
    public class DesignerAddressConfiguration : IEntityTypeConfiguration<DesignerAddress>
    {
        public void Configure(EntityTypeBuilder<DesignerAddress> builder)
        {
            builder.Property(x => x.City)
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);
        }
    }
}
