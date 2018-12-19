using System.Linq;
using ABPCoreSpa.EntityFramework;
using ABPCoreSpa.MultiTenancy;

namespace ABPCoreSpa.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPCoreSpaDbContext _context;

        public DefaultTenantCreator(ABPCoreSpaDbContext context)
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
