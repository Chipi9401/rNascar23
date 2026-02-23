using rNascar26.Schedules.Models;
using System.Threading.Tasks;

namespace rNascar26.Schedules.Ports
{
    public interface ISchedulesRepository
    {
        Task<SeriesSchedules> GetRaceListAsync(int? year = null);
    }
}
