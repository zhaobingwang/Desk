using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Desk.Data;
using Volo.Abp.DependencyInjection;

namespace Desk.EntityFrameworkCore
{
    public class EntityFrameworkCoreDeskDbSchemaMigrator
        : IDeskDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDeskDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DeskMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DeskMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}