using Desk.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data
{
    public class DeskDbContextV2 : DbContext
    {
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<AssetRecord> AssetRecords { get; set; }
        public DbSet<SysDict> SysDicts { get; set; }
        public DbSet<SysDictType> SysDictTypes { get; set; }

        internal string ConnectionString { get; }
        public DeskDbContextV2(string connectionString)
        {
            ConnectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<AssetType>(entity =>
            //{
            //    entity.ToTable("AssetType");
            //    entity.HasKey(x => x.Code);
            //    entity.HasIndex(x => x.Name).IsUnique();

            //    entity.Property(x => x.Code).HasMaxLength(64).IsRequired();
            //    entity.Property(x => x.Name).HasMaxLength(64).IsRequired();
            //});

            //modelBuilder.Entity<AssetRecord>(entity =>
            //{
            //    entity.ToTable("AssetRecord");
            //    entity.HasKey(x => x.Id);

            //    entity.Property(x => x.Id);
            //    entity.Property(x => x.TypeCode).HasMaxLength(64).IsRequired();
            //    entity.Property(x => x.TypeName).HasMaxLength(64).IsRequired();
            //    entity.Property(x => x.TotalAsset).IsRequired();
            //    entity.Property(x => x.CreateTime).IsRequired();
            //    entity.Property(x => x.IsDeleted).IsRequired();
            //});
        }
    }
}
