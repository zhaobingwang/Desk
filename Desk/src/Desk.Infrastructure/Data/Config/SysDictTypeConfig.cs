using Desk.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data.Config
{
    public class SysDictTypeConfig : IEntityTypeConfiguration<SysDictType>
    {
        public void Configure(EntityTypeBuilder<SysDictType> builder)
        {
            builder.ToTable(nameof(SysDictType));

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => new { x.Code, x.InternalVersion }).IsUnique();

            builder.Property(x => x.Code).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.IsBuiltin).IsRequired().HasMaxLength(1);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(4);
            builder.Property(x => x.InternalVersion).IsRequired().HasMaxLength(10);
            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.CreateUser).IsRequired().HasMaxLength(50);
            builder.Property(x => x.UpdateTime).IsRequired();
            builder.Property(x => x.UpdateUser).IsRequired().HasMaxLength(50);
        }
    }
}
