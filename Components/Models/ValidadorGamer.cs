namespace GamesKorn.Components.Models
{
    public static class ValidadorGamer
    {
        public static bool EsNombreValido(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;
            return nombre.Length >= 3 && nombre.Length <= 20;
        }

        public static bool EsEmailValido(string mail)
        {
            if (string.IsNullOrWhiteSpace(mail)) return false;
            return mail.Contains("@") && mail.Contains(".") && mail.Contains("com" );
        }

        public static bool EsContrasenaValida(string contra)
        {
            if (string.IsNullOrWhiteSpace(contra)) return false;
            return contra.Length >= 6;
        }

        public static bool EsEdadValida(DateTime fechaNacimiento)
        {
            if (fechaNacimiento == DateTime.MinValue || fechaNacimiento > DateTime.Today) return false;

            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }

            return edad >= 13 && edad <= 100;
        }
    }
}