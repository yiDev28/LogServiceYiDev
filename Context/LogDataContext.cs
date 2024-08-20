

using EncryptorService.Services;
using LogServiceYiDev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LogServiceYiDev.Data
{
    public class LogDataContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly IEncryptionService _encryptionService;

        public LogDataContext(IConfiguration configuration, IEncryptionService encryptionService)
        {
            _configuration = configuration;
            _encryptionService = encryptionService;
        }

        public DbSet<LogModel> admlogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("AdmonDatabaseConnection");
            optionsBuilder.UseMySql(_encryptionService.DecryptString(connectionString, "nil6BZYakrYZrtMw"),
                new MySqlServerVersion(new Version(8, 0, 21)));

        }
    }
}
