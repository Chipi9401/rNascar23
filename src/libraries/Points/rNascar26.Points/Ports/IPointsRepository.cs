using rNascar26.Points.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rNascar26.Points.Ports
{
    public interface IPointsRepository
    {
        Task<IList<DriverPoints>> GetDriverPoints(int raceId, int seriesId);
        Task<IList<StagePoints2>> GetStagePoints(int raceId, int seriesId);
    }
}
