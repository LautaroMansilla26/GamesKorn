//BUSQUEDA CON TECLA ENTER
window.gamesKornInterop = {
    inicializarBuscadorEnter: function (dotNetHelper, inputElement) {
        if (!inputElement) return;

        inputElement.addEventListener("keydown", function (event) {
            if (event.key === "Enter") {
                event.preventDefault();
                // Le pasamos el valor actual del input directo a C# para que nunca llegue vacío
                dotNetHelper.invokeMethodAsync("BuscarDesdeJS", inputElement.value);
            }
        });
    }
};
//BOTON VOLVER ARRIBA
window.scrollHelpers = {
    inicializarScrollTop: function (dotNetHelper) {
        window.addEventListener('scroll', () => {
            const scrollTopBtn = document.getElementById('btnVolverArriba');
            if (scrollTopBtn) {
                if (window.pageYOffset > 300) {
                    scrollTopBtn.classList.add('mostrar');
                } else {
                    scrollTopBtn.classList.remove('mostrar');
                }
            }
        });
    },
    scrollToTop: function () {
        window.scrollTo({
            top: 0,
            behavior: 'smooth'
        });
    }
};