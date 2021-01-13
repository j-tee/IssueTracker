using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TrackerLibrary.Shared;

namespace TrackerAuthAdmin.Configuration.DbContextFactory
{
    public class IdentityServerConfigurationDbContextFactory : IDesignTimeDbContextFactory<IdentityServerConfigurationDbContext>
    {
        public IdentityServerConfigurationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<IdentityServerConfigurationDbContext>();
            var connectionString = configuration.GetConnectionString("ConfigurationDbConnection");
            builder.UseSqlServer(connectionString);
            return new IdentityServerConfigurationDbContext(builder.Options,new ConfigurationStoreOptions());
        }
    }
}
