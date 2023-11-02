using GalaxyQuest.Models;

namespace GalaxyQuest
{
    public interface ISWAPIService
    {
        Task<List<PlanetModel>> GetPlanets();
    }
}
