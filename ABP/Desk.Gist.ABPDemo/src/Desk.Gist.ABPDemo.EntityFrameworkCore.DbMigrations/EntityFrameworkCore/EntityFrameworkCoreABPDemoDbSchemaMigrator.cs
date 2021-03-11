using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Desk.Gist.ABPDemo.Data;
using Volo.Abp.DependencyInjection;

namespace Desk.Gist.ABPDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreABPDemoDbSchemaMigrator
        : IABPDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreABPDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ABPDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ABPDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}