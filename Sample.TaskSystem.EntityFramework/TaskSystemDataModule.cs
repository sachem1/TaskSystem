using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Sample.TaskSystem.EntityFramework;

namespace Sample.TaskSystem
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(TaskSystemCoreModule))]
    public class TaskSystemDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TaskSystemDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
