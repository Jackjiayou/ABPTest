using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABPCoreSpa.EntityFramework;

namespace ABPCoreSpa.Migrator
{
    [DependsOn(typeof(ABPCoreSpaDataModule))]
    public class ABPCoreSpaMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABPCoreSpaDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}