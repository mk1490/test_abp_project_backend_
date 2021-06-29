using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Matin.Test.App.EntityFrameworkCore
{
    [DependsOn(
        typeof(AppEntityFrameworkCoreModule)
        )]
    public class AppEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AppMigrationsDbContext>();
        }
    }
}
