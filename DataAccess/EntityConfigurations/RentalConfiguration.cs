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
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("Rentals").HasKey(x => x.Id);

            builder.Property(x => x.RentDate).HasColumnName("RentDate").IsRequired();

            builder.Property(x => x.ReturnDate).HasColumnName("ReturnDate");



            builder.HasOne(x => x.Car);
            builder.HasOne(x => x.Customer);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
