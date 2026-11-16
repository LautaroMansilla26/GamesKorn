using System.ComponentModel.DataAnnotations;

namespace GamesKorn.Components.Models
{
    public class RegistroModel : IValidatableObject
    {
        public string Nombre { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public string Contra { get; set; } = string.Empty;
        public string ConfirmarContra { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; } = DateTime.Today.AddYears(-18);
        public string ColorAvatar { get; set; } = "#00FF66";

            
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!ValidadorGamer.EsNombreValido(Nombre))
            {
                yield return new ValidationResult(
                    "El nombre de usuario debe tener entre 3 y 20 caracteres.",
                    new[] { nameof(Nombre) }
                );
            }

            if (!ValidadorGamer.EsEmailValido(Mail))
            {
                yield return new ValidationResult(
                    "Ingresa un correo electrónico válido.",
                    new[] { nameof(Mail) }
                );
            }

            if (!ValidadorGamer.EsContrasenaValida(Contra))
            {
                yield return new ValidationResult(
                    "La contraseña debe tener al menos 6 caracteres.",
                    new[] { nameof(Contra) }
                );
            }

            if (Contra != ConfirmarContra)
            {
                yield return new ValidationResult(
                    "Las contraseñas no coinciden.",
                    new[] { nameof(ConfirmarContra) }
                );
            }

            if (!ValidadorGamer.EsEdadValida(FechaNacimiento))
            {
                yield return new ValidationResult(
                    "Debes tener entre 13 y 100 años para registrarte.",
                    new[] { nameof(FechaNacimiento) }
                );
            }
        }
    }
}