using rNascar26.LiveFeeds.Models;
using System.Threading.Tasks;

namespace rNascar26.Data.LiveFeeds.Ports
{
    public interface ILiveFeedRepository
    {
        Task<LiveFeed> GetLiveFeedAsync();
    }
}
