using GalaxyQuest.Models;
using GalaxyQuest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace GalaxyQuest.Controllers
{
    public class PlanetsController : Controller
    {
        private readonly ISWAPIService _SWAPIService;

        public PlanetsController(ISWAPIService SWAPIService)
        {
            _SWAPIService = SWAPIService;
        }

        public async Task<IActionResult> Index()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets;
            List<PlanetModel> swPlanets = new List<PlanetModel>();
            swPlanets = await _SWAPIService.GetPlanets();
            ViewData["swPlanets"] = swPlanets;

            return View(milkyWayPlanets);
        }
    }
}
