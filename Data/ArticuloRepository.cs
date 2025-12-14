using GamingZoneApp.Models;

namespace GamingZoneApp.Data
{
    public static class ArticuloRepository
    {
        private static List<Articulo> _articulos = new();

        public static List<Articulo> ObtenerArticulos()
        {
            return _articulos;
        }

        public static bool CodigoExiste(string codigo)
        {
            return _articulos.Any(a => a.CodigoInterno == codigo);
        }

        public static void AgregarArticulo(Articulo articulo)
        {
            _articulos.Add(articulo);
        }
    }
}
