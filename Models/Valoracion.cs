namespace SummonerMatch.Models
{
    public class Valoracion
    {
        private int _idValoracion;
        private float _media;
        private int _numValoraciones;
        private int _fkUsuario;

        public int _IdValoracion {  get { return _idValoracion;} set { _idValoracion = value;} }
        public float Media { get { return _media; } set { _media = value; } }
        public int NumValoraciones { get {  return _numValoraciones; } set { _numValoraciones = value; } }
        public int FkUsuario { get {  return _fkUsuario; } set { _fkUsuario = value; } }

        public Valoracion(int IdValoracion, float Med, int NumeroVal, int FKUsuario)
        {
            _idValoracion = IdValoracion;
            _media = Med;
            _numValoraciones = NumeroVal;
            _fkUsuario = FKUsuario;
        }

        public Valoracion(float Med, int NumeroVal, int FKUsuario)
        {
            _media = Med;
            _numValoraciones = NumeroVal;
            _fkUsuario = FKUsuario;
        }
    }
}
