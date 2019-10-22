using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DigitArc.AdminBackend.Data
{
    /* This is used if database provider does't define
     * IAdminBackendDbSchemaMigrator implementation.
     */
    public class NullAdminBackendDbSchemaMigrator : IAdminBackendDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}