using Matin.Test.App.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Matin.Test.App.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AppEntityFrameworkCoreDbMigrationsModule),
        typeof(AppApplicationContractsModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class AppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
            context.Services.AddAbpDbContext<AppDbContext>();
        }
    }
}