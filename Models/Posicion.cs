namespace SummonerMatch.Models
{
    public class Posicion
    {
        private int _idPosicion;
        private string _nombrePosicion;

        public int _IdPosicion { get { return _idPosicion;} set { _idPosicion = value; } }
        public string _NombrePosicion { get { return _nombrePosicion;} set { _nombrePosicion = value; } }

        public Posicion(int IdPosicion, string NombrePosicion)
        {
            _idPosicion = IdPosicion;
            _nombrePosicion = NombrePosicion;
        }

        public Posicion(string NombrePosicion)
        {
            _nombrePosicion = NombrePosicion;
        }
    }
}
