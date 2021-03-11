using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Desk.Gist.ABPDemo.EntityFrameworkCore
{
    public static class ABPDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureABPDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ABPDemoConsts.DbTablePrefix + "YourEntities", ABPDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}