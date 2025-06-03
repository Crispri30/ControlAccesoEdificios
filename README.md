# Sistema de Control de Acceso a Edificios
Este proyecto tiene como propósito fundamental explorar a fondo las tecnologías ADO.NET y Entity Framework. Buscamos comprender en detalle sus funcionalidades y características para alcanzar el objetivo principal de lograr una mayor escalabilidad en nuestro código. Adicionalmente, aspiramos a adquirir el conocimiento y la experiencia suficiente para desarrollar soluciones de programación cada vez más avanzadas.

## Diagrama entidad-relación:
![image](https://github.com/user-attachments/assets/38c6121a-d8f8-4c24-a50f-92554d4fac17)

## Descripción de funcionalidades:

## Funcionalidades principales:
### 1. Auntenticación de usuarios:
Permite el inicio de sesión por parte de usuarios con roles autorizados (Administrador, Seguridad), usando el procedimiento almacenado SP_ValidarLogin.

### 2. Control de accesos:
Registro y validación de entradas y salidas de personas (empleados o visitantes) al edificio. Controlado desde una interfaz específica para personal de seguridad.

### 3. Gestión de empleados:
Permite registrar, modificar, consultar y eliminar (CRUD) datos de empleados desde el panel de Admin. Cada empleado tiene roles asignados que afectan su nivel de acceso.

### 4. Alertas de seguridad:
Generación automática de alertas cuando se detectan intentos de acceso no autorizados, fuera de horario o por usuarios no registrados mediante SP_GenerarAlerta.

### 5. Panel del Admin:
Permite:
- Registrar nuevos usuarios.
- Consultar historial de accesos.
- Ver y gestionar alertas.
- Gestinar empleados y sus zonas de acceso.
- Ver monitoreo en tiempo real.

### 6. Panel del personal de seguridad:
Interfaz dedicada al personal de vigilancia para controlar accesos en tiempo real, verificar identidades y actuar ante alertas emitidas.

### 7. Monitoreo en tiempo real:
Actualización automática cada 5 segundos mediante un Timer en el formulario FormSeguridad, mostrando accesos con FechaHoraEntrada no nula y FechaHoraSalida nula.

## Estructura del proyecto
![image](https://github.com/user-attachments/assets/57391605-ca80-43f3-ade8-00c5b1cc60c1)


## Patrones y principios aplicados
### Patrones:
- Repository: Cada entidad principal tiene su repositorio que abstrae el acceso a datos.
- Singleton: Aplicado en ConexionBD.cs para asegurar una única instancia de conexión activa a la BD.

### Principios SOLID:
- S - Responsabilidad única: Cada clase tiene una sola responsabilidad (repositorio, modelo, interfaz).
- O - Abierto/Cerrado: Se pueden agregar nuevas funcionalidades sin modificar las clases existentes.

## Manual básico de usuario
### Ingreso al sistema:
1. Ejecutar la aplicación.
2. Iniciar sesión con credenciales válidas (Administrador o Seguridad).
   Administrador
  1. Usuario: Cristian Contraseña: 3000
  2. Usuario: Manuela Contraseña: 2000
   Seguridad
  1. Usuario: Camilo Contraseña: 1000

### Como administrador:
- Crear empleados y asignar roles.
- Consultar registros de acceso.
- Visualizar alertas.

### Como personal de seguridad:
- Registrar entrada/salida de personas.
- Monitorear en tiempo real accesos activos.
- Generar alertas cuando sea necesario.

## Capturas y evidencias:
### Formulario de acceso:
![image](https://github.com/user-attachments/assets/b160d9ea-fdb5-430e-bc72-ed15759c9c90)

### Panel del Admin:
![image](https://github.com/user-attachments/assets/110ccfa2-5bbc-4d62-8510-e52a6a79c9fb)

### Alertas generadas:
![image](https://github.com/user-attachments/assets/293b116e-13df-4fdc-b186-675fd8742036)


### Monitoreo en tiempo real:
![image](https://github.com/user-attachments/assets/ee022476-e6a6-440b-acd0-fa1913db391c)

## Evidencias de pruebas:
### Prueba de ingreso/salida de empleado:
Ingreso de empleado:
![image](https://github.com/user-attachments/assets/5abbda16-5372-41f2-ba11-2fac5851a623)
![image](https://github.com/user-attachments/assets/4cb98beb-e885-49e0-bd62-6c6b38e24f35)

Salida de empleado:
![image](https://github.com/user-attachments/assets/88ba1792-39a1-4a49-99d5-63fc55e03b8b)
![image](https://github.com/user-attachments/assets/53dd433f-2329-4655-b7de-a65d81c8a92c)


### Acceso fuera de horario genera alerta:
![image](https://github.com/user-attachments/assets/8eabe1ce-4488-4233-898e-0b2443f8a6e7)

### Verificacion del monitoreo activo:
![image](https://github.com/user-attachments/assets/e84d93dd-104b-4afb-a55b-b79e38ebf5b6)

## Tecnologías utilizadas:
- Lenguaje de programación C#
- Plataforma de desarrollo .NET 6
- Interfaz gráfica Windows Forms
- IDE Visual Studio
- Base de datos SQL Server
- Acceso a datos ADO.NET
- Patrón Repository/Singleton
- Principios SOLID
- Control de versiones GitHub


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
