using rNascar26.LiveFeeds.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rNascar26.LiveFeeds.Ports
{
    public interface IKeyMomentsRepository
    {
        Task<IList<KeyMoment>> GetKeyMomentsAsync(int seriesId, int raceId, int? year = null);
    }
}
