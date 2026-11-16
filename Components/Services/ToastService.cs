namespace GamesKorn.Services
{
    public class ToastService
    {
        public event Action<string>? OnShow;

        public void Mostrar(string mensaje)
        {
            OnShow?.Invoke(mensaje);
        }
    }
}