namespace SummonerMatch.Models
{
    public class Torneo
    {
        private int _idTorneo;
        private string _nombreTorneo;
        private string _descripcionTorneo;
        private int _cantEquipos;
        private int _fkIdCreador;

        public int _IdTorneo { get { return _idTorneo; } set { _idTorneo = value; } }
        public string _NombreTorneo { get { return _nombreTorneo;}set { _nombreTorneo = value; } }
        public string _DescripcionTorneo { get { return _descripcionTorneo; } set { _descripcionTorneo = value; } }
        public int _CantEquipos { get { return _cantEquipos; } set { _cantEquipos = value; } }
        public int _FkIdCreador {  get { return _fkIdCreador;} set { _fkIdCreador = value; } }

        public Torneo() { }

        public Torneo(int IdTorneo, string NombreTorneo, string DescripcionTorneo, int CantEquipos, int FKIdCreador)
        {
            _idTorneo = IdTorneo;
            _nombreTorneo = NombreTorneo;
            _descripcionTorneo = DescripcionTorneo;
            _cantEquipos = CantEquipos;
            _fkIdCreador = FKIdCreador;
        }

        public Torneo(string NombreTorneo, string DescripcionTorneo, int CantEquipos, int FKIdCreador)
        {
            _nombreTorneo = NombreTorneo;
            _descripcionTorneo = DescripcionTorneo;
            _cantEquipos = CantEquipos;
            _fkIdCreador = FKIdCreador;
        }
    }
}
