using Desk.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data
{
    public class DeskDbContext : DbContext
    {
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<AssetRecord> AssetRecords { get; set; }

        public DeskDbContext(DbContextOptions<DeskDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.ToTable("AssetType");
                entity.HasKey(x => x.Code);
                entity.HasIndex(x => x.Name).IsUnique();

                entity.Property(x => x.Code).HasMaxLength(64).IsRequired();
                entity.Property(x => x.Name).HasMaxLength(64).IsRequired();
            });

            modelBuilder.Entity<AssetRecord>(entity =>
            {
                entity.ToTable("AssetRecord");
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Id);
                entity.Property(x => x.TypeCode).HasMaxLength(64).IsRequired();
                entity.Property(x => x.TypeName).HasMaxLength(64).IsRequired();
                entity.Property(x => x.TotalAsset).IsRequired();
                entity.Property(x => x.CreateTime).IsRequired();
                entity.Property(x => x.IsDeleted).IsRequired();
            });
        }
    }
}
