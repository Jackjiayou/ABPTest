using ABPCoreSpa.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABPCoreSpa.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPCoreSpaDbContext _context;

        public InitialHostDbBuilder(ABPCoreSpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
