using rNascar26.LapTimes.Models;
using System.Collections.Generic;

namespace rNascar26.LapTimes.Ports
{
    public interface IMoversFallersService
    {
        IList<PositionChange> GetDriverPositionChanges(LapTimeData lapTimeData);
    }
}
