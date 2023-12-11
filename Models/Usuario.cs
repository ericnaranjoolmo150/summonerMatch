namespace SummonerMatch.Models
{
    public class Usuario
    {
        private int _idUsuario;
        private bool _admin;
        private string _userName;
        private string _userNickname;
        private string _email;
        private string _password;
        private int? _fkRegionServidor;
        private int? _fkRango;
        private int? _fkPosicion;
        private int _fkImagenPerfil;
        private int? _fkIdEquipo;


        public int IdUsuario { get { return _idUsuario;} set { _idUsuario = value; } }
        public bool Admin { get { return _admin; } set { _admin = value; } }
        public string UserName { get { return _userName; } set { _userName = value; } }
        public string UserNickname { get { return _userNickname; } set { _userNickname = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public int? FkRegionServidor { get {  return _fkRegionServidor; } set { _fkRegionServidor = value;} }
        public int? FkRango { get { return _fkRango;} set { _fkRango = value; } }
        public int? FkPosicion { get {  return _fkPosicion; } set { _fkPosicion = value; } }
        public int FkImagenPerfil {  get { return _fkImagenPerfil;} set { _fkImagenPerfil = value; } }
        public int? FkIdEquipo {  get { return _fkIdEquipo; } set { _fkIdEquipo = value; } }

        public Usuario() { }

        public Usuario(int IdUser, bool Adm, string UsrName, string UsrNick, string Mail, string Pass, int FKRegionServidor, int FKRango, int FKPosicion, int FKImgagenPerfil, int FKIdEquipo)
        {
            _idUsuario = IdUser;
            _admin = Adm;
            _userName = UsrName;
            _userNickname = UsrNick;
            _email = Mail;
            _password = Pass;
            _email = Mail;
            _password = Pass;
            _fkRegionServidor = FKRegionServidor;
            _fkRango = FKRango;
            _fkPosicion = FKPosicion;
            _fkImagenPerfil = FKImgagenPerfil;
            _fkIdEquipo = FKIdEquipo;
        }

        public Usuario(bool Adm, string UsrName, string UsrNick, string Mail, string Pass, int FKRegionServidor, int FKRango, int FKPosicion, int FKImgagenPerfil, int FKIdEquipo)
        {
            _admin = Adm;
            _userName = UsrName;
            _userNickname = UsrNick;
            _email = Mail;
            _password = Pass;
            _email = Mail;
            _password = Pass;
            _fkRegionServidor = FKRegionServidor;
            _fkRango = FKRango;
            _fkPosicion = FKPosicion;
            _fkImagenPerfil = FKImgagenPerfil;
            _fkIdEquipo = FKIdEquipo;
        }
    }
}
