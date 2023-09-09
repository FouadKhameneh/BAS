using ICD.Base.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Data.Map;

public class TeacherTestTypeMap
{
    public class TeacherTestMap : IEntityTypeConfiguration<TeacherTestEntity>
    {
        public void Configure(EntityTypeBuilder<TeacherTestEntity> builder)
        {
            builder.ToTable("Teacher_Test", "BAS");

            builder.HasKey(pt => pt.Key);

            builder.Property(pt => pt.Key).HasColumnName("TeacherId").ValueGeneratedOnAdd().IsRequired();
            builder.Property(pt => pt.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(pt => pt.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder.Property(pt => pt.Point).HasColumnName("Point").IsRequired(false);
        }
    }
}