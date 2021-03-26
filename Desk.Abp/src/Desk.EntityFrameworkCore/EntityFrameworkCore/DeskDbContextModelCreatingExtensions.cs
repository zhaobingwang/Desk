using Desk.Assets;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Desk.EntityFrameworkCore
{
    public static class DeskDbContextModelCreatingExtensions
    {
        public static void ConfigureDesk(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DeskConsts.DbTablePrefix + "YourEntities", DeskConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<AssetRecord>(ar =>
            {
                ar.ToTable(DeskConsts.DbTablePrefix + "AssetRecords", DeskConsts.DbSchema);
                ar.ConfigureByConvention();
                ar.Property(x => x.Name).IsRequired().HasMaxLength(AssetConsts.MaxRecordNameLength);
                ar.Property(x => x.Price).IsRequired();
                ar.HasOne<AssetCategory>().WithMany().HasForeignKey(x => x.CategoryId).IsRequired();
            });

            builder.Entity<AssetCategory>(ac =>
            {
                ac.ToTable(DeskConsts.DbTablePrefix + "AssetCategories", DeskConsts.DbSchema);
                ac.ConfigureByConvention();
                ac.Property(x => x.Name).IsRequired().HasMaxLength(AssetConsts.MaxCategoryNameLength);
                ac.HasIndex(x => x.Name);
            });
        }
    }
}