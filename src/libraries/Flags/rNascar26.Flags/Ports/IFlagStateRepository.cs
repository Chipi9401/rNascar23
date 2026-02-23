using rNascar26.Flags.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rNascar26.Data.Flags.Ports
{
    public interface IFlagStateRepository
    {
        Task<IList<FlagState>> GetFlagStatesAsync();
    }
}
