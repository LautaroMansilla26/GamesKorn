using System.ComponentModel.DataAnnotations;

namespace GamesKorn.Components.Models
{
    public class ProductoModelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        [Range(0.01, 1000000, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        public string ImagenUrl { get; set; } = string.Empty;

        public string EtiquetaTexto { get; set; } = string.Empty;

        public string DetallesTecnicos { get; set; } = string.Empty;

        // Relación con Subcategoría
        [Required(ErrorMessage = "Debe seleccionar una subcategoría")]
        public int SubCategoriaId { get; set; }

        public SubCategoriaModelo? SubCategoria { get; set; }
    }
}