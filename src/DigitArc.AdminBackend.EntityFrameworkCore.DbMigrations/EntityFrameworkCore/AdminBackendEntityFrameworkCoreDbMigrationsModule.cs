using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace DigitArc.AdminBackend.EntityFrameworkCore
{
    [DependsOn(
        typeof(AdminBackendEntityFrameworkCoreModule)
        )]
    public class AdminBackendEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AdminBackendMigrationsDbContext>();
        }
    }
}
