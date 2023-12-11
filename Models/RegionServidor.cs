namespace SummonerMatch.Models
{
    public class RegionServidor
    {
        private int _idRegionServidor;
        private string _nombreRegion;

        public int _IdRegionServidor {  get { return _idRegionServidor;} set { _idRegionServidor = value; } }
        public string _NombreRegion { get { return _nombreRegion; } set { _nombreRegion = value; } }

        public RegionServidor(int IdRegionServer, string NombreRegion)
        {
            _idRegionServidor = IdRegionServer;
            _nombreRegion = NombreRegion;
        }

        public RegionServidor(string NombreRegion)
        {
            _nombreRegion = NombreRegion;
        }
    }
}
