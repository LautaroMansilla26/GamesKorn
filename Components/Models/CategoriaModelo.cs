using System.ComponentModel.DataAnnotations;

namespace GamesKorn.Components.Models
{
    public class CategoriaModelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        // Relación 1 a Muchos con Subcategorías
        public List<SubCategoriaModelo> SubCategorias { get; set; } = new();
    }
}