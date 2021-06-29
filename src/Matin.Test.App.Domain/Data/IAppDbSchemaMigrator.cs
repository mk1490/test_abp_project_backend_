using System.Threading.Tasks;

namespace Matin.Test.App.Data
{
    public interface IAppDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
