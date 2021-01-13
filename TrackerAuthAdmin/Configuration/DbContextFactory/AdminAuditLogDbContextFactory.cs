using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TrackerLibrary.Configurations.Common;

namespace TrackerAuthAdmin.Configuration.DbContextFactory
{
    public class AdminAuditLogDbContextFactory : IDesignTimeDbContextFactory<AdminAuditLogDbContext>
    {
        public AdminAuditLogDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<AdminAuditLogDbContext>();
            var connectionString = configuration.GetConnectionString("AdminAuditLogDbConnection");
            builder.UseSqlServer(connectionString);
            return new AdminAuditLogDbContext(builder.Options);
        }
    }
}
