using Matin.Test.App.Contents;
using Microsoft.EntityFrameworkCore;
using Matin.Test.App.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Matin.Test.App.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See AppMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class AppDbContext : AbpDbContext<AppDbContext>
    {
        // public DbSet<AppUser> Users { get; set; }
        public DbSet<AppContent> Book { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside AppDbContextModelCreatingExtensions.ConfigureApp
         */

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users");

                b.ConfigureByConvention();
                b.ConfigureAbpUser();
            });
            builder.ConfigureApp();
        }
    }
}