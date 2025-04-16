# ToDo List Backend - API

Este es el backend de una aplicación de lista de tareas (ToDo List) que maneja las operaciones CRUD (Create, Read, Update, Delete) de tareas. El proyecto está construido utilizando **ASP.NET Core** y **Entity Framework** con **SQL Server** como base de datos.

## Requisitos previos

Antes de levantar el proyecto, asegúrate de tener lo siguiente instalado:

- **.NET 6.0 o superior**: Este proyecto está construido con **.NET 6.0**. Si no lo tienes instalado, puedes descargarlo desde [aquí](https://dotnet.microsoft.com/download/dotnet).
- **SQL Server**: Asegúrate de tener **SQL Server** corriendo. Puedes usar **SQL Server Express** o **LocalDB** para desarrollo local.
- **Visual Studio** o **Visual Studio Code**: Usa **Visual Studio 2022** o **Visual Studio Code** con las extensiones de C# para trabajar en el proyecto.

## Clonar el proyecto

Primero, clona el repositorio a tu máquina local:

```bash
git clone https://github.com/tu-usuario/ToDo-Backend.git
cd ToDo-Backend

### Conexión a la base de datos: ###

Asegúrate de que tu archivo appsettings.json contenga la cadena de conexión correcta a tu base de datos de SQL Server.

### Ejecutar las migraciones a la BD: ###

Con la base de datos ToDoAppDb creada ejecuta:
- dotnet ef database update
- dotnet build
- desde Visual Studio 2022 levanta el proyecto con https

### Endpoints disponibles en la API:
GET /api/ToDo: Obtiene todas las tareas.
GET /api/ToDo/{id}: Obtiene una tarea específica por ID.
POST /api/ToDo: Crea una nueva tarea.
PUT /api/ToDo/{id}: Actualiza una tarea existente por ID.
DELETE /api/ToDo/{id}: Elimina una tarea por ID.



...cRISPIN ©

