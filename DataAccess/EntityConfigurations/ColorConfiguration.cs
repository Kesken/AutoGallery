using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colors").HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired();

            builder.HasMany(x => x.CarColors)
               .WithOne(cc => cc.Color)
               .HasForeignKey(cc => cc.ColorId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
