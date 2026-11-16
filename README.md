#  GamesKorn

Plataforma web de tienda y catálogo digital de videojuegos desarrollada con **.NET 8** y **Blazor**, 
conectada a una base de datos relacional en la nube y desplegada mediante integración y entrega continua (CI/CD).

🌐 **Aplicación desplegada en Azure:** [gameskorn-store-gdgefya8ckese3gp.westus3-01.azurewebsites.net]

---

##  Tecnologías utilizadas

* **Framework / Frontend & Backend:** .NET 8 (Blazor Web App)
* **Acceso a Datos (ORM):** Entity Framework Core 8
* **Base de Datos:** Azure SQL Database (`GamesKornDB`) / SQL Server LocalDB
* **Cloud Hosting:** Azure App Service (Linux - Runtime `.NET 8.0`)
* **CI/CD & Control de Versiones:** Git, GitHub y GitHub Actions

---

##  Requisitos previos

Para ejecutar este proyecto de forma local necesitás tener instalado:

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads) (LocalDB o Express) y SQL Server Management Studio (SSMS)
* Herramienta CLI de Entity Framework Core:
  ```bash
  dotnet tool install --global dotnet-ef

  🚀 Instalación y ejecución local
Clonar el repositorio:

Bash
git clone [https://github.com/LautaroMansilla26/GamesKorn.git](https://github.com/LautaroMansilla26/GamesKorn.git)
cd GamesKorn
Configurar la cadena de conexión:
En el archivo appsettings.json (o mediante User Secrets), configurá DefaultConnection apuntando a tu instancia local de SQL Server:

JSON
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=GamesKornDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Aplicar las migraciones de base de datos:

Bash
dotnet ef database update
Ejecutar la aplicación:

Bash
dotnet run
Luego abrí tu navegador en la URL que indique la consola (habitualmente https://localhost:7xxx o http://localhost:5xxx).


📁 Estructura del proyecto
Plaintext
GamesKorn/
├── .github/workflows/       # Pipelines de CI/CD para despliegue automático en Azure
├── Components/
│   ├── Models/              # Entidades y modelos de dominio (Producto, Categoria, SubCategoria)
│   └── Pages/               # Componentes Razor y vistas de la interfaz Blazor
├── Data/                    # AppDbContext y configuración de Entity Framework Core
├── Migrations/              # Historial de migraciones de base de datos
├── wwwroot/                 # Archivos estáticos (CSS, imágenes, favicon)
├── docs/                    # Documentación técnica del sistema
├── appsettings.json         # Configuración general de la aplicación
└── Program.cs               # Punto de entrada, inyección de dependencias y middlewares

Para conocer en detalle el funcionamiento interno del sistema, consultá los siguientes documentos:

📐 Arquitectura y Despliegue (CI/CD)

🗄️ Modelo de Base de Datos y Migraciones﻿
