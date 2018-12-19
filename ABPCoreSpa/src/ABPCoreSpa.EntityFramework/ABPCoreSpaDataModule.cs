using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ABPCoreSpa.EntityFramework;

namespace ABPCoreSpa
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ABPCoreSpaCoreModule))]
    public class ABPCoreSpaDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ABPCoreSpaDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
