namespace SummonerMatch.Models
{
    public class Equipo
    {
        private int _idEquipo;
        private bool _posicionTop;
        private bool _posicionMid;
        private bool _posicionJungla;
        private bool _posicionSupport;
        private bool _posicionAdc;
        private int? _fkRangoEquipo;
        private int _idPartida;

        public int _IdEquipo { get { return _idEquipo; } set { _idEquipo = value; } }
        public bool _PosicionTop { get { return _posicionTop;} set { _posicionTop = value; } }
        public bool _PosicionMid { get { return _posicionMid; } set { _posicionMid = value; } }
        public bool _PosicionJungla { get { return _posicionJungla;} set {  _posicionJungla = value;} }
        public bool _PosicionSupport { get {  return _posicionSupport; } set { _posicionSupport = value; } }
        public bool _PosicionAdc {  get { return _posicionAdc;} set { _posicionAdc = value; } }
        public int? _FkRangoEquipo { get { return _fkRangoEquipo; } set { _fkRangoEquipo = value; } }
        public int _IdPartida { get { return _idPartida; } set { _idPartida = value; } }

        public Equipo() { }

        public Equipo (int IdEquipo, bool PosicionTop, bool PosicionMid, bool PosicionJungla, bool PosicionSupport, bool PosicionAdc, int? FKRangoEquipo, int IdPartida)
        {
            _idEquipo = IdEquipo;
            _posicionTop = PosicionTop;
            _posicionMid = PosicionMid;
            _posicionJungla = PosicionJungla;
            _posicionSupport = PosicionSupport;
            _posicionAdc = PosicionAdc;
            _fkRangoEquipo = FKRangoEquipo;
            _idPartida = IdPartida;
        }

        public Equipo(bool PosicionTop, bool PosicionMid, bool PosicionJungla, bool PosicionSupport, bool PosicionAdc, int? FKRangoEquipo, int IdPartida)
        {
            _posicionTop = PosicionTop;
            _posicionMid = PosicionMid;
            _posicionJungla = PosicionJungla;
            _posicionSupport = PosicionSupport;
            _posicionAdc = PosicionAdc;
            _fkRangoEquipo = FKRangoEquipo;
            _idPartida = IdPartida;
        }
    }
}
