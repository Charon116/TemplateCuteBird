using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TemplateCuteBird.Data.EF
{
    public class TemplateShopDbContextFactory : IDesignTimeDbContextFactory<TemplateShopDbContext>
    {
        public TemplateShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionStrings = configuration.GetConnectionString("TemplateShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<TemplateShopDbContext>();
            optionsBuilder.UseSqlServer(connectionStrings);
            return new TemplateShopDbContext(optionsBuilder.Options);
        }
    }
}
