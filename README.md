# MoneyUp

MoneyUp es una aplicación web orientada a jóvenes para organizar y comprender mejor sus finanzas personales.

## Estado actual

La versión actual incluye:

- Landing pública como pantalla inicial (`/`)
- Pantalla de bienvenida (`/inicio`)
- Inicio de sesión (`/iniciar-sesion`)
- Registro (`/registrarse`)
- Identidad visual y recursos gráficos de MoneyUp
- Formularios preparados para incorporar persistencia y autenticación en una etapa posterior

## Tecnologías

- ASP.NET Core MVC
- .NET 9
- Razor Views
- HTML y CSS

## Ejecución

Desde la carpeta del proyecto:

```bash
dotnet run --project MoneyUp.Web.csproj
```

Luego abrir la URL local indicada por ASP.NET Core.

## Próximas etapas

- Conexión con base de datos
- Registro e inicio de sesión reales
- Gestión de movimientos, metas y estadísticas
- Integración del asistente educativo Up
