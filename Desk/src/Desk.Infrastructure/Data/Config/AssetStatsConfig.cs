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
    public class AssetStatsConfig : IEntityTypeConfiguration<AssetStats>
    {
        public void Configure(EntityTypeBuilder<AssetStats> builder)
        {
            builder.ToTable("AssetStats");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);
            builder.Property(x => x.Keyword).HasMaxLength(20).IsRequired();
        }
    }
}
