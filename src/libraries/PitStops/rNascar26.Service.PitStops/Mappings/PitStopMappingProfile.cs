using AutoMapper;
using rNascar26.PitStops.Models;
using rNascar26.Service.PitStops.Data.Models;

namespace rNascar26.Service.PitStops.Mappings
{
    internal class PitStopMappingProfile : Profile
    {
        public PitStopMappingProfile()
        {
            CreateMap<PitStopModel, PitStop>();
        }
    }
}
