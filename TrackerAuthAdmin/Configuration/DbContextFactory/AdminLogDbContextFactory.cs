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
    public class AdminLogDbContextFactory : IDesignTimeDbContextFactory<AdminLogDbContext>
    {
        public AdminLogDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<AdminLogDbContext>();
            var connectionString = configuration.GetConnectionString("AdminLogDbConnection");
            builder.UseSqlServer(connectionString);
            return new AdminLogDbContext(builder.Options);
        }
    }
}
