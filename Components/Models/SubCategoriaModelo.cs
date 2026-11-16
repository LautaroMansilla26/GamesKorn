using System.ComponentModel.DataAnnotations;

namespace GamesKorn.Components.Models
{
    public class SubCategoriaModelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la subcategoría es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        // Relación con Categoría (Una Categoría tiene muchas Subcategorías)
        [Required(ErrorMessage = "Debe seleccionar una categoría principal")]
        public int CategoriaId { get; set; }
        public CategoriaModelo? Categoria { get; set; }

        // Relación con Productos (Una Subcategoría tiene muchos Productos)
        public List<ProductoModelo> Productos { get; set; } = new();
    }
}