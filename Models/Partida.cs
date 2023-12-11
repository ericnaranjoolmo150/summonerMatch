namespace SummonerMatch.Models
{
    public class Partida
    {
        private int _idCardPartida;
        private DateTime _horaCreacion;
        private DateTime _horaExpiracion;
        private int _fkIdCreador;
        private int _fkTipoPartida;
        private int? _fkidTorneo;

        public int _IdCardPArtida { get { return _idCardPartida; } set { _idCardPartida = value; } }
        public DateTime _HoraCreacion {  get { return _horaCreacion;}set { _horaCreacion = value; } }
        public DateTime _HoraExpiracion { get { return _horaExpiracion;} set {  _horaExpiracion = value;} }
        public int _FkIdCreador {  get { return _fkIdCreador;} set { _fkIdCreador = value; } }
        public int _FkTipoPartida {  get { return _fkTipoPartida;} set { _fkTipoPartida = value;} }
        public int? _FKIdTorneo { get { return _fkidTorneo; } set { _fkidTorneo} }

        public Partida() { }

        public Partida(int IDCardPartida, DateTime HoraCreacion, DateTime HoraExpiracion, int FKIdCreador, int FKTipoPartida, int? FKIdTorneo)
        {
            _idCardPartida = IDCardPartida;
            _horaCreacion = HoraCreacion;
            _horaExpiracion = HoraExpiracion;
            _fkIdCreador = FKIdCreador;
            _fkTipoPartida = FKTipoPartida;
            _fkidTorneo = FKIdTorneo;
        }

        public Partida(DateTime HoraCreacion, DateTime HoraExpiracion, int FKIdCreador, int FKTipoPartida, int? FKIdTorneo)
        {
            _horaCreacion = HoraCreacion;
            _horaExpiracion = HoraExpiracion;
            _fkIdCreador = FKIdCreador;
            _fkTipoPartida = FKTipoPartida;
            _fkidTorneo = FKIdTorneo;
        }
    }
}
