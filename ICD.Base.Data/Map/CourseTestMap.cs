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
    public class CourseTestMap : IEntityTypeConfiguration<CourseTestEntity>
    {
        public void Configure(EntityTypeBuilder<CourseTestEntity> builder)
        {
            builder.ToTable("Course_Test", "BAS");

            builder.HasKey(ct => ct.Key);

            builder.Property(ct => ct.Key).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(ct => ct.Title).HasColumnName("Title").HasMaxLength(50).IsRequired();
            builder.Property(ct => ct.Grade).HasColumnName("Grade").IsRequired();

            builder.HasOne(ct=>ct.PersonTest).WithMany(pt=>pt.CourseTests).HasForeignKey(ct => ct.PersonTestRef);
        }
    }
}
