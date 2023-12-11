namespace SummonerMatch.Models
{
    public class TipoPartida
    {
        private int _idTipoPartida;
        private string _nombreTipo;

        public int _IdTipoPartida {  get { return _idTipoPartida;} set { _idTipoPartida = value; } }
        public string _NombreTipo { get { return _nombreTipo;} set { _nombreTipo = value; } }

        public TipoPartida() { }

        public TipoPartida(int IdTipoPartida, string NombreTipo)
        {
            _idTipoPartida = IdTipoPartida;
            _nombreTipo = NombreTipo;
        }
    }
}
