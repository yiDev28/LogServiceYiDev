using LogServiceYiDev.Models;

namespace LogServiceYiDev.Interfaces
{
    public interface ILogService
    {
        Task LogAsync(LogModel logEntry);
    }
}
