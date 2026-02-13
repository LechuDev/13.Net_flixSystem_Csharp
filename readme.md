# 🎬 Proyecto 13 – .NET_flixSys

Clon inspirado en **Netflix**, desarrollado en **ASP.NET Core MVC (C#)** con **Entity Framework Core (SQLite)**.  
El sistema permite explorar un catálogo de películas, marcar favoritas y recibir recomendaciones personalizadas.

---

## 🚀 Tecnologías

- **.NET 9.0**
- **ASP.NET Core MVC**
- **Entity Framework Core (SQLite)**
- **TailwindCSS vía CDN** (diseño moderno sin instalación local)
- **LINQ** para consultas y lógica de recomendación

---

## 🏗️ Arquitectura

- **Controllers** → manejan catálogo y recomendaciones  
- **Models** → `Usuario`, `Pelicula`, `Preferencia`  
- **Data** → `AppDbContext` con seeding de datos simulados  
- **Services** → `RecomendacionService` para lógica de sugerencias  
- **Views** → interfaz estilo Netflix con TailwindCSS  

---

## 📂 Estructura del proyecto

```cmd
13.Net_flixSystem_Csharp/
 ├── Controllers/
 │    ├── CatalogoController.cs
 │    └── RecomendacionesController.cs
 ├── Data/
 │    └── AppDbContext.cs
 ├── Models/
 │    ├── Usuario.cs
 │    ├── Pelicula.cs
 │    └── Preferencia.cs
 ├── Services/
 │    └── RecomendacionService.cs
 ├── Views/
 │    ├── Catalogo/
 │    │    ├── Index.cshtml
 │    │    └── Detalles.cshtml
 │    └── Recomendaciones/
 │         └── Sugerencias.cshtml
 ├── wwwroot/
 │    └── css/ (Tailwind vía CDN en layout)
 ├── Program.cs
 ├── appsettings.json
 └── NetFlixSys.csproj
```

---

## 📌 Uso

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/LechuDev/13.Net_flixSystem_Csharp.git
   cd 13.Net_flixSystem_Csharp
   ```

2. Restaurar dependencias:

   ```bash
   dotnet restore
   ```

3. Crear base de datos:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. Ejecutar:

   ```bash
   dotnet run
   ```

---

## 🎯 Valor del proyecto

- Demuestra cómo clonar un sistema popular (Netflix) con **ASP.NET Core MVC**.  
- Arquitectura limpia con **MVC + Services**.  
- Catálogo lleno con **20+ películas simuladas**.  
- Diseño moderno con **TailwindCSS vía CDN**.  

---

## 🌐 Portfolio

👉 [Volver al Portfolio](https://lechudev.github.io/Porfolio)
