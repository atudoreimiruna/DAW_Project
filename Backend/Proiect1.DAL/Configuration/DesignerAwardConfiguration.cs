using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect1.DAL.Entities;

namespace Proiect1.DAL.Configurations 
{
    public class DesignerAwardConfiguration : IEntityTypeConfiguration<DesignerAward>
    {
        public void Configure(EntityTypeBuilder<DesignerAward> builder)
        {
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)").HasMaxLength(200);
            builder.Property(x => x.Contest).HasColumnType("nvarchar(100)").HasMaxLength(100);
        }
    }
}
