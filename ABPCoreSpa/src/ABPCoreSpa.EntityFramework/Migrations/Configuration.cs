using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using ABPCoreSpa.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace ABPCoreSpa.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ABPCoreSpa.EntityFramework.ABPCoreSpaDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ABPCoreSpa";
        }

        protected override void Seed(ABPCoreSpa.EntityFramework.ABPCoreSpaDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
