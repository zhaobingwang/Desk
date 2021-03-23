using Microsoft.EntityFrameworkCore;
using Volo.Abp;

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
        }
    }
}