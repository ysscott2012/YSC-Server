using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using YSC_Server.Extension;
using YSC_Server.Models;

namespace YSC_Server.DbContext.DesignTime
{
    // Detail info: 
    // https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dbcontext-creation
    public class YscDesignTimeDbContextFactory: IDesignTimeDbContextFactory<YscContext>
    {
        public YscContext CreateDbContext(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<YscContext>();
            var dbConfig = config.GetSection("YscDatabase").Get<DatabaseConfiguration>();
            builder.UseMySql(dbConfig.GetMySqlConnectionString());
            return new YscContext(builder.Options);
        }
    }
}