using System.Threading.Tasks;

namespace Desk.Data
{
    public interface IDeskDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
