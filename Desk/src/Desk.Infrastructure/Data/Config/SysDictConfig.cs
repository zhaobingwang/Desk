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
    public class SysDictConfig : IEntityTypeConfiguration<SysDict>
    {
        public void Configure(EntityTypeBuilder<SysDict> builder)
        {
            builder.ToTable(nameof(SysDict));

            builder.HasKey(x => x.Code);

            builder.HasIndex(x => x.Code).IsUnique();
            builder.Property(x => x.Code).IsRequired().HasMaxLength(32);
        }
    }
}
