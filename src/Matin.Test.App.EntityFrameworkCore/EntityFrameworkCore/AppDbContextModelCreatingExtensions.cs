
using Matin.Test.App.Contents;
using Matin.Test.App.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Matin.Test.App.EntityFrameworkCore
{
    public static class AppDbContextModelCreatingExtensions
    {
        public static void ConfigureApp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<AppContent>(b =>
            {
                b.ToTable(AppConsts.DbTablePrefix + "Contents", AppConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Title).IsRequired().HasMaxLength(128);
            });
        }
    }
}