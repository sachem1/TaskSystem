using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Sample.TaskSystem.EntityFramework;

namespace Sample.TaskSystem.Migrator
{
    [DependsOn(typeof(TaskSystemDataModule))]
    public class TaskSystemMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TaskSystemDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}