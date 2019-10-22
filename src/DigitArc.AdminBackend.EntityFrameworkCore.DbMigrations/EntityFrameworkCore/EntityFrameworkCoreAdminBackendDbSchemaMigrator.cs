using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DigitArc.AdminBackend.Data;
using Volo.Abp.DependencyInjection;

namespace DigitArc.AdminBackend.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreAdminBackendDbSchemaMigrator 
        : IAdminBackendDbSchemaMigrator, ITransientDependency
    {
        private readonly AdminBackendMigrationsDbContext _dbContext;

        public EntityFrameworkCoreAdminBackendDbSchemaMigrator(AdminBackendMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}