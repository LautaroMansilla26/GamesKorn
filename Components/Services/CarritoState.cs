using GamesKorn.Components.Models;

namespace GamesKorn.Services
{
    public class CarritoState
    {
        private readonly ToastService _toastService;

        public CarritoState(ToastService toastService)
        {
            _toastService = toastService;
        }

        public List<ProductoModelo> Items { get; private set; } = new();

        public event Action? OnChange;

        public void AgregarProducto(ProductoModelo producto)
        {
            Items.Add(producto);
            NotifyStateChanged();
            _toastService.Mostrar($"¡'{producto.Nombre}' agregado al carrito!");
        }

        public void RemoverProducto(ProductoModelo producto)
        {
            Items.Remove(producto);
            NotifyStateChanged();
            _toastService.Mostrar($"'{producto.Nombre}' eliminado del carrito");
        }

        public void VaciarCarrito()
        {
            Items.Clear();
            NotifyStateChanged();
            _toastService.Mostrar("Se ha vaciado el carrito");
        }

        public decimal ObtenerTotal()
        {
            return Items.Sum(p => p.Precio);
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}