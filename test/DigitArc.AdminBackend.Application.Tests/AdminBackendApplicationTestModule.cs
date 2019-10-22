using Volo.Abp.Modularity;

namespace DigitArc.AdminBackend
{
    [DependsOn(
        typeof(AdminBackendApplicationModule),
        typeof(AdminBackendDomainTestModule)
        )]
    public class AdminBackendApplicationTestModule : AbpModule
    {

    }
}