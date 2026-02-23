using rNascar26.LiveFeeds.Models;
using System.Threading.Tasks;

namespace rNascar26.LiveFeeds.Ports
{
    public interface IWeekendFeedRepository
    {
        Task<WeekendFeed> GetWeekendFeedAsync(int seriesId, int raceId, int? year = null);
    }
}
