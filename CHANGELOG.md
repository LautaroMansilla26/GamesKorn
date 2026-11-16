# Changelog

Todas las versiones notables del proyecto **GamesKorn** serán documentadas en este archivo.

## [1.0.0] - 2026-10-26
### Añadido
- Catálogo de productos gamer con filtrado multinivel por categorías y subcategorías.
- Buscador global sincronizado en tiempo real con `FiltroService`, soporte para tecla `Enter` y botón de limpieza rápida.
- Gestión de carrito de compras con estado reactivo (`CarritoState`).
- Componente flotante de desplazamiento "Volver arriba" implementado mediante JavaScript Interop (`app.js`).
- Menú lateral retráctil adaptado para dispositivos móviles con capa translúcida de cierre automático (*backdrop*).
- Persistencia de datos mediante Entity Framework Core, SQL Server y migraciones versionadas.
- Configuración de entornos separada (`appsettings.json`, `.Development.json`, `.Production.json`).
- Pipeline de CI/CD automatizado con GitHub Actions para despliegue en producción.