# Sistema de Control de Acceso a Edificios
Este proyecto tiene como propósito fundamental explorar a fondo las tecnologías ADO.NET y Entity Framework. Buscamos comprender en detalle sus funcionalidades y características para alcanzar el objetivo principal de lograr una mayor escalabilidad en nuestro código. Adicionalmente, aspiramos a adquirir el conocimiento y la experiencia suficiente para desarrollar soluciones de programación cada vez más avanzadas.

## Diagrama entidad-relación:
![image](https://github.com/user-attachments/assets/47f5c6a0-896b-4bbf-95d1-fb068bda9ddd)

## Descripción de funcionalidades:

## Funcionalidades principales:
### 1. Auntenticación de usuarios:
Permite que los usuarios autorizados como admin. o personal de seguridad inicien sesión en el sistema mediante las credenciales.

### 2. Control de accesos:
Registro y validación de entradas y salidas de personas (empleados o visitantes) al edificio. Controlado desde una interfaz específica para personal de seguridad.

### 3. Gestión de empleados:
Permite registrar, modificar, consultar y eliminar datos de empleados. Cada empleado tiene roles asignados que afectan su nivel de acceso.

### 4. Alertas de seguridad:
Generación automática de alertas cuando se detectan intentos de acceso no autorizados, fuera de horario o por usuarios no registrados.

### 5. Panel del Admin:
Acceso a un formulario exclusivo con funcionalidades avanzadas para la gestión del sistema, como creación de usuarios, consulta de accesos y revisión de alertas.

### 6. Panel del personal de seguridad:
Interfaz dedicada al personal de vigilancia para controlar accesos en tiempo real, verificar identidades y actuar ante alertas emitidas.


## Tecnologías utilizadas:
- Lenguaje de programación C#
- Plataforma de desarrollo .NET 6
- Interfaz gráfica Windows Forms
- IDE Visual Studio
- Base de datos SQL Server
- Acceso a datos ADO.NET
- Control de versiones GitHub

## Captura de pantalla iniciales:


## Instrucciones para compilar y ejecutar:

### 1. Requisitos
- Visual Studio 2019 o superior
- .NET Framework 4.7.2 o superior
- SQL Server LocalDB o SQL Server Express

### 2. Pasos para ejecutar

#### 1. Clona el repositorio:
git clone https://github.com/tu-usuario/ControlEdificios.git

#### 2. Abre la solución en Visual Studio: ControlEdificios.sln.

#### 3.Restarurar la base de datos:

- Ubica el archivo ControlAccesoEdificios.sql en la carpeta Base de datos.
- Ábrelo en SQL Server Management Studio (SSMS) o en el editor de consultas de Visual Studio.
- Ejecuta el script para crear la base de datos ControlEdificios, sus tablas y los datos predeterminados de login de usuarios.

#### 4. Configura la cadena de conexión en la clase ConexionBD.cs:

- private readonly string connectionString =="miConexion" connectionString="Server=.;Database=ControlEdificios;Trusted_Connection=True;TrustServerCertificate=True;"

#### 5. Compila el proyecto (Ctrl + Shift + B).

#### 6. Ejecuta la aplicación (F5).
