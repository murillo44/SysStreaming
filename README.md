SysStreaming

SysStreaming es un proyecto CRUD desarrollado en C# con Windows Forms y ADO.NET, orientado a la gestión de entidades a través de una base de datos relacional. El objetivo principal es practicar arquitectura en capas e interacción directa con la base de datos sin el uso de frameworks ORM.

Solución parcial — en desarrollo.


Estructura del proyecto
UI/        → Interfaz gráfica desarrollada con Windows Forms
BLL/       → Lógica de negocio (Business Logic Layer)
DAL/       → Acceso a datos y ejecución de comandos sobre la base de datos (Data Access Layer)
Entity/    → Clases que representan las entidades del modelo de datos
Mapper/    → Traducción entre entidades y resultados de base de datos
.sln       → Archivo de solución de Visual Studio

Funcionalidades

ABM completo de registros (alta, baja y modificación)
Conexión directa a la base de datos mediante SqlConnection de ADO.NET
Arquitectura en capas con separación de responsabilidades


📸 Screenshot
![image](https://github.com/user-attachments/assets/f8d72752-38a1-4073-9dc1-ebd7319682c9)

Tecnologías utilizadas

Lenguaje: C# (.NET Framework)
UI: Windows Forms (WinForms)
Acceso a datos: ADO.NET (SqlConnection, SqlCommand, SqlDataReader)
Base de datos: SQL Server
Entorno de desarrollo: Visual Studio


Proyecto universitario desarrollado para la práctica de arquitectura en capas y acceso a datos con ADO.NET.
