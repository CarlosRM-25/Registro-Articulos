using System.ComponentModel.DataAnnotations;

namespace GamingZoneApp.Models
{
    public class Articulo
    {
        [Required(ErrorMessage = "El nombre del artículo es obligatorio")]
        [StringLength(100, MinimumLength = 3)]
        public string ArticuloNombre { get; set; }

        [Required(ErrorMessage = "El proveedor es obligatorio")]
        [StringLength(100, MinimumLength = 3)]
        public string Proveedor { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una categoría")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El año de lanzamiento es obligatorio")]
        [Range(1970, 2100)]
        public int AnioLanzamiento { get; set; }

        [Required(ErrorMessage = "El número de artículos es obligatorio")]
        [Range(1, int.MaxValue)]
        public int NumeroArticulos { get; set; }

        [Required(ErrorMessage = "El código interno es obligatorio")]
        [RegularExpression(@"^ART-\d{3}$", ErrorMessage = "Formato: ART-001")]
        public string CodigoInterno { get; set; }

        [Required(ErrorMessage = "Debe indicar disponibilidad")]
        public bool Disponible { get; set; }
    }
}
