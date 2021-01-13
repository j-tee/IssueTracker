using IssueTracker.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrackableEntities.Common.Core;
using TrackerLibrary.Helpers;

namespace TrackerLibrary.Shared
{
    public class IssuesDbContext : DbContext
    {
        public IssuesDbContext(DbContextOptions<IssuesDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Types<IObjectState>().Configure(c => c.Ignore(p => p.State));
            // Interface that all of our Entity maps implement
            var mappingInterface = typeof(IEntityTypeConfig<>);

            // Types that do entity mapping
            var mappingTypes = typeof(IssuesDbContext).GetTypeInfo().Assembly.GetTypes()
                .Where(x => x.GetInterfaces().Any(y => y.GetTypeInfo().IsGenericType && y.GetGenericTypeDefinition() == mappingInterface));

            // Get the generic Entity method of the ModelBuilder type
            var entityMethod = typeof(ModelBuilder).GetMethods()
                .Single(x => x.Name == "Entity" &&
                        x.IsGenericMethod &&
                        x.ReturnType.Name == "EntityTypeBuilder`1");

            foreach (var mappingType in mappingTypes)
            {
                // Get the type of entity to be mapped
                var genericTypeArg = mappingType.GetInterfaces().Single().GenericTypeArguments.Single();

                // Get the method builder.Entity<TEntity>
                var genericEntityMethod = entityMethod.MakeGenericMethod(genericTypeArg);

                // Invoke builder.Entity<TEntity> to get a builder for the entity to be mapped
                var entityBuilder = genericEntityMethod.Invoke(builder, null);

                // Create the mapping type and do the mapping
                var mapper = Activator.CreateInstance(mappingType);
                mapper.GetType().GetMethod("Map").Invoke(mapper, new[] { entityBuilder });
            }
            builder.UseHiLo("DBSequence");
        }
        public int GetTotalCount(string sql, params SqlParameter[] sqlparams)
        {
            return DBQueryExtensionHelper.GetTotalCount(this, sql, sqlparams);
        }



        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        public void SyncObjectsStatePostCommit()
        {
            foreach (var dbEntityEntry in ChangeTracker.Entries())
            {
                ((ITrackable)dbEntityEntry.Entity).TrackingState = StateHelper.ConvertState(dbEntityEntry.State);
            }
        }

        public virtual void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, ITrackable
        {
            Entry(entity).State = StateHelper.ConvertState(entity.TrackingState);
        }
    }
}
