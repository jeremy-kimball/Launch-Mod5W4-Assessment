namespace GalaxyQuest.Models
{
    public class PlanetModel
    {
        public string Name { get; set; }
        public string Diameter { get; set; }
        public string RotationPeriod { get; set; }
        public string OrbitalPeriod { get; set; }
        public string Gravity { get; set; }
        public string Population { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string SurfaceWater { get; set; }
        public ICollection<string> Residents { get; set; }
        public ICollection<string> Films { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
    }
}
