using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Desk.Data
{
    /* This is used if database provider does't define
     * IDeskDbSchemaMigrator implementation.
     */
    public class NullDeskDbSchemaMigrator : IDeskDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}