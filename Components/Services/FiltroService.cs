namespace GamesKorn.Components.Services
{
    public class FiltroService
    {
        public string TerminoBusqueda { get; set; } = string.Empty;

        public event Action? OnChange;

        public void ActualizarTermino(string termino)
        {
            TerminoBusqueda = termino;
            OnChange?.Invoke();
        }
    }
}