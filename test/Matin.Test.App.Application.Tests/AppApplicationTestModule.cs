using Volo.Abp.Modularity;

namespace Matin.Test.App
{
    [DependsOn(
        typeof(AppApplicationModule),
        typeof(AppDomainTestModule)
        )]
    public class AppApplicationTestModule : AbpModule
    {

    }
}