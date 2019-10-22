using DigitArc.AdminBackend.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DigitArc.AdminBackend.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AdminBackendEntityFrameworkCoreDbMigrationsModule),
        typeof(AdminBackendApplicationContractsModule)
        )]
    public class AdminBackendDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
