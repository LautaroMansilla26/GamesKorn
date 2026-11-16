Modelo de Base de Datos y Migraciones

## Estructura Relacional (`AppDbContext`)

La base de datos **GamesKornDB** utiliza **Entity Framework Core** con enfoque *Code-First*. El esquema principal está compuesto por una jerarquía de tres niveles para organizar el catálogo de productos:

* **`Categorias` (`CategoriaModelo`):** Agrupación principal del catálogo (ej. Géneros o Plataformas).
* **`SubCategorias` (`SubCategoriaModelo`):** Clasificación específica dependiente de una categoría padre (`CategoriaId`).
* **`Productos` (`ProductoModelo`):** Artículos/videojuegos disponibles en la tienda, vinculados a una subcategoría (`SubCategoriaId`).

### Reglas de Integridad Referencial
En `AppDbContext.OnModelCreating` se configuraron explícitamente las claves foráneas con restricción de borrado (`DeleteBehavior.Restrict`):
* Una **Categoría** contiene muchas **SubCategorías** (`1:N`). No se permite eliminar una categoría si tiene subcategorías asociadas.
* Una **SubCategoría** contiene muchos **Productos** (`1:N`). No se permite eliminar una subcategoría si tiene productos asociados.

---

## Gestión de Migraciones

Para aplicar el esquema en una base de datos nueva o actualizar cambios tras modificar los modelos:

```bash
# Crear una nueva migración (solo si se modificaron modelos)
dotnet ef migrations add NombreDeLaMigracion

# Aplicar las migraciones pendientes a la base de datos configurada
dotnet ef database update







































### 3. Cómo subir todo a GitHub (usando la rama y Conventional Commits)

Abrí la terminal dentro de la carpeta exacta de tu proyecto (`C:\EDI TERCERO\GamesKorn2`) y ejecutá estos comandos en orden:

```powershell
# 1. Asegurate de estar en la carpeta del proyecto
cd "C:\EDI TERCERO\GamesKorn2"

# 2. Verificá que estás en la rama de documentación (si ya la creaste, te va a decir que ya estás ahí)
git checkout -b docs/subida-documentacion

# 3. Agregá el README.md y la carpeta docs/ completa
git add README.md docs/

# 4. Guardá los cambios respetando Conventional Commits
git commit -m "docs: agregar README profesional y documentacion tecnica"

# 5. Subí la rama a GitHub
git push -u origin docs/subida-documentacion