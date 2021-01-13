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
    public class AdminIdentityDbContextFactory : IDesignTimeDbContextFactory<AdminIdentityDbContext>
    {
        public AdminIdentityDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<AdminIdentityDbContext>();
            var connectionString = configuration.GetConnectionString("IdentityDbConnection");
            builder.UseSqlServer(connectionString);
            return new AdminIdentityDbContext(builder.Options);
        }
    }
}
