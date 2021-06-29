using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Matin.Test.App.Data;
using Volo.Abp.DependencyInjection;

namespace Matin.Test.App.EntityFrameworkCore
{
    public class EntityFrameworkCoreAppDbSchemaMigrator
        : IAppDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAppDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AppMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AppMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}