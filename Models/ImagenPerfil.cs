namespace SummonerMatch.Models
{
    public class ImagenPerfil
    {
        private int _idImagenPerfil;
        private byte[] _archivoImagen;

        public int IdImagenPerfil {  get { return _idImagenPerfil; } set { _idImagenPerfil = value; } }
        public byte[] ArchivoImagen { get {  return _archivoImagen; } set { _archivoImagen = value; } }

        public ImagenPerfil(int IdImagen, byte[] Imagen)
        {
            _idImagenPerfil = IdImagen;
            _archivoImagen = Imagen;
        }

        public ImagenPerfil(byte[] Imagen)
        {
            _archivoImagen = Imagen;
        }
    }
}
