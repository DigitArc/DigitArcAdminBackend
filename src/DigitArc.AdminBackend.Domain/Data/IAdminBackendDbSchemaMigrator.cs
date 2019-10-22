using System.Threading.Tasks;

namespace DigitArc.AdminBackend.Data
{
    public interface IAdminBackendDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
