# 📐 Arquitectura y Despliegue (CI/CD)

## Arquitectura de la aplicación

**GamesKorn** está construida bajo una arquitectura monolítica modular sobre **Blazor (.NET 8)**:

1. **Capa de Presentación (`Components/`):** Interfaces interactivas renderizadas en servidor mediante componentes Razor, gestionando navegación, catálogo y formularios de usuario.
2. **Capa de Dominio (`Components/Models/`):** Clases C# que definen las entidades del negocio (`ProductoModelo`, `CategoriaModelo`, `SubCategoriaModelo`).
3. **Capa de Acceso a Datos (`Data/AppDbContext.cs`):** Contexto de **Entity Framework Core** encargado del mapeo objeto-relacional (ORM), las reglas de integridad referencial y la comunicación con SQL Server.

---

## Flujo de Integración y Entrega Continua (CI/CD)

El proyecto cuenta con un pipeline automatizado en **GitHub Actions** (`.github/workflows/deploy.yml`):

1. **Disparador (Trigger):** Cada `push` o *Merge* hacia la rama `main` inicia el flujo automáticamente.
2. **Compilación (Build & Publish):** El runner de GitHub restaura paquetes NuGet, compila la solución en modo `Release` bajo el SDK `.NET 8.0` y genera el paquete listo para producción (`dotnet publish`).
3. **Despliegue (Deploy):** Mediante credenciales autenticadas en Azure, el artefacto compilado se publica directamente sobre el App Service **gameskorn-store** (entorno Linux configurado en `DOTNETCORE|8.0`), conectándose en tiempo de ejecución a **Azure SQL Database** (`GamesKornDB`) mediante variables de entorno seguras.


