using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Configuration
{
    public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(100)").HasMaxLength(100);
            builder.Property(x => x.Message).HasColumnType("nvarchar(3000)").HasMaxLength(3000);
        }
    }
}
