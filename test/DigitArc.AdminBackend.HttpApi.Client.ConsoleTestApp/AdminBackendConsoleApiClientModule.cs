using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace DigitArc.AdminBackend.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AdminBackendHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AdminBackendConsoleApiClientModule : AbpModule
    {
        
    }
}
