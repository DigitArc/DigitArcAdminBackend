using DigitArc.AdminBackend.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DigitArc.AdminBackend
{
    [DependsOn(
        typeof(AdminBackendEntityFrameworkCoreTestModule)
        )]
    public class AdminBackendDomainTestModule : AbpModule
    {

    }
}