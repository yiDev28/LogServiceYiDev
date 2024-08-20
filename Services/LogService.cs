using LogServiceYiDev.Data;
using LogServiceYiDev.Interfaces;
using LogServiceYiDev.Models;

namespace LogServiceYiDev.Services
{
    public class LogService : ILogService
    {
        private readonly LogDataContext _context;

        public LogService(LogDataContext context)
        {
            _context = context;
        }

        public async Task LogAsync(LogModel logEntry)
        {
            _context.admlogs.Add(logEntry);
            await _context.SaveChangesAsync();
        }
    }
}
