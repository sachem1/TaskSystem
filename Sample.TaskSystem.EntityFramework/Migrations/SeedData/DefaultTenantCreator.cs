using System.Linq;
using Sample.TaskSystem.EntityFramework;
using Sample.TaskSystem.MultiTenancy;

namespace Sample.TaskSystem.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TaskSystemDbContext _context;

        public DefaultTenantCreator(TaskSystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
