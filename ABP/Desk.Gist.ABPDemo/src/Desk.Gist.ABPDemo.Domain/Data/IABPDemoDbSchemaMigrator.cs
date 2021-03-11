using System.Threading.Tasks;

namespace Desk.Gist.ABPDemo.Data
{
    public interface IABPDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
