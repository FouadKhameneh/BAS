using ICD.Base.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Data.Map
{
    public class PersonTestMap : IEntityTypeConfiguration<PersonTestEntity>
    {
        public void Configure(EntityTypeBuilder<PersonTestEntity> builder)
        {
            builder.ToTable("Person_Test", "BAS");

            builder.HasKey(pt => pt.Key);

            builder.Property(pt => pt.Key).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(pt => pt.FName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(pt => pt.LName).HasColumnName("LastName").HasMaxLength(50).IsRequired(false);
        }
    }
}
