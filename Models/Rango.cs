namespace SummonerMatch.Models
{
    public class Rango
    {
        private int _idRango;
        private string _nombreRango;

        public int IdRango { get { return _idRango; } set { _idRango = value;} }
        public string NombreRango { get {  return _nombreRango; } set { _nombreRango = value; } }

        public Rango(int IdRang, string RangName)
        {
            _idRango = IdRang;
            _nombreRango = RangName;
        }

        public Rango(string RangName)
        {
            _nombreRango = RangName;
        }
    }
}
