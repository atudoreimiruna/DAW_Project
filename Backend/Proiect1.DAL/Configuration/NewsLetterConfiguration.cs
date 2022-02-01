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
    public class NewsLetterConfiguration : IEntityTypeConfiguration<NewsLetter>
    {
        public void Configure(EntityTypeBuilder<NewsLetter> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).HasColumnType("nvarchar(200)").HasMaxLength(200);
        }
    }
}
