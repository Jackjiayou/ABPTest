using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPCoreSpa.EntityFramework.Repositories
{
    public abstract class ABPCoreSpaRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPCoreSpaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPCoreSpaRepositoryBase(IDbContextProvider<ABPCoreSpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPCoreSpaRepositoryBase<TEntity> : ABPCoreSpaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPCoreSpaRepositoryBase(IDbContextProvider<ABPCoreSpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
