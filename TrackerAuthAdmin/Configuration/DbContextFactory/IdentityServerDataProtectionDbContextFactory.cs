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
    public class IdentityServerDataProtectionDbContextFactory : IDesignTimeDbContextFactory<IdentityServerDataProtectionDbContext>
    {
        public IdentityServerDataProtectionDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<IdentityServerDataProtectionDbContext>();
            var connectionString = configuration.GetConnectionString("DataProtectionDbConnection");
            builder.UseSqlServer(connectionString);
            return new IdentityServerDataProtectionDbContext(builder.Options);
        }
    }
}
