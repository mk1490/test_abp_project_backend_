using Matin.Test.App.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Matin.Test.App
{
    [DependsOn(
        typeof(AppEntityFrameworkCoreTestModule)
        )]
    public class AppDomainTestModule : AbpModule
    {

    }
}