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
    public class AssetRecordConfig : IEntityTypeConfiguration<AssetRecord>
    {
        public void Configure(EntityTypeBuilder<AssetRecord> builder)
        {
            builder.ToTable("AssetRecord");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);
            builder.Property(x => x.TypeCode).HasMaxLength(64).IsRequired();
            builder.Property(x => x.TypeName).HasMaxLength(64).IsRequired();
            builder.Property(x => x.TotalAsset).IsRequired();
            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
        }
    }
}
