

namespace GamesKorn.Data
{
    public class BusquedaState
    {
        public string TerminoBusqueda { get; set; } = string.Empty;

        public event Action? OnChange;

        public void EstablecerTermino(string termino)
        {
            TerminoBusqueda = termino;
            OnChange?.Invoke();
        }
    }
}