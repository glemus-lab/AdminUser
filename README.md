\# Proyecto para la administración de usuarios e inicio de sesión

Este repositorio contiene dos proyectos principales para la gestión de usuarios, integrados con una base de datos centralizada.



\## Descripción del ejercicio

El objetivo es demostrar el manejo de operaciones CRUD y autenticación utilizando dos tecnologías diferentes bajo .NET 8:

1\.  \*\*WinForms (VB.NET):\*\* Aplicación de escritorio diseñada para la creación, edición y eliminación (CRUD) de usuarios.

2\.  \*\*ASP.NET 8 MVC:\*\* Aplicación web enfocada exclusivamente en el módulo de Login y autenticación de usuario.



---



\## Base de Datos e Instrucciones SQL

Para garantizar el funcionamiento de ambos proyectos, se debe configurar la base de datos siguiendo estos pasos:



1\.  \*\*Localización del script:\*\*

    \*   Abrir el archivo `setup\\\_db.sql` disponible en el directorio raíz del proyecto.

2\.  \*\*Ejecución de objetos:\*\*

    \*   Ejecutar el script en la instancia local de SQL Server para generar la estructura de la tabla `Usuarios` y los procedimientos almacenados.



---



\## Pasos para ejecutar los proyectos



\### 1. Proyecto WinForms (Gestión de Usuarios)

\*   \*\*Navegar\*\* a la carpeta `WinForms` del proyecto de escritorio.

\*   \*\*Abrir\*\* el archivo de solución `UsuarioApp.sln` en Visual Studio.

\*   \*\*Actualizar\*\* la cadena de conexión en el archivo `appsettings.json` (dentro de la carpeta `UsuarioApp`) con las credenciales locales.

\*   \*\*Iniciar\*\* la aplicación mediante la tecla `F5`.



\### 2. Proyecto MVC (Login de Usuario)

\*   \*\*Navegar\*\* a la carpeta `WebApplication` del proyecto web.

\*   \*\*Abrir\*\* el archivo de solución `LoginUsuarioWebbApp.sln` en Visual Studio.

\*   \*\*Actualizar\*\* la cadena de conexión en el archivo `appsettings.json` (dentro de la carpeta `LoginUsuarioWebbApp`) con las credenciales locales.

\*   \*\*Compilar y ejecutar\*\* el proyecto para desplegar la interfaz de Login en el navegador.

