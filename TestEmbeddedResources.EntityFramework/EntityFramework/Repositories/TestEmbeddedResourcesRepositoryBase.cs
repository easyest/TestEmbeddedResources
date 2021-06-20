using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TestEmbeddedResources.EntityFramework.Repositories
{
    public abstract class TestEmbeddedResourcesRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TestEmbeddedResourcesDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TestEmbeddedResourcesRepositoryBase(IDbContextProvider<TestEmbeddedResourcesDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TestEmbeddedResourcesRepositoryBase<TEntity> : TestEmbeddedResourcesRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TestEmbeddedResourcesRepositoryBase(IDbContextProvider<TestEmbeddedResourcesDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
