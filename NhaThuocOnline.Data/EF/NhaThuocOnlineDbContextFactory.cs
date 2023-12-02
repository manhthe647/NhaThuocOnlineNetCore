using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.EF
{
    public class NhaThuocOnlineDbContextFactory : IDesignTimeDbContextFactory<NhaThuocOnlineDbContext>
    {
        public NhaThuocOnlineDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("NhaThuocOnlineDb");

            var optionsBuilder = new DbContextOptionsBuilder<NhaThuocOnlineDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new NhaThuocOnlineDbContext(optionsBuilder.Options);
        }
    }
}
