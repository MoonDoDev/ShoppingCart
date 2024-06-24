# Solución WebApi con .NET 8, MongoDB, y contenerizada con Docker

## Descripción General

Esta es una Solución desarrollada en Visual Studio Code, con .NET 8, MongoDB, y Docker. 
La solución se está implementando paso a paso en una serie de videos que se están publicando en mi canal de [YouTube](https://tinyurl.com/42x8zvyv)

## La solución incluye la siguiente funcionallidad:

### [:] Proyecto de tipo ClassLib que nos permitirá realizar la conexión a una Base de Datos de MongoDB.
  - Se crea la clase para realizar la conexión a MongoDB.
  - Se crean los modelos para definir las colecciones en la BD.
  - Se crean los DTO's (Data Transfer Objects) para intercambiar información con el FrontEnd.
  - [Instructivo con el paso a paso](https://tinyurl.com/3cvzyzud)
    
### [:] Proyecto de tipo ClassLib como base para implementar las REST APIs.
  - Se crea una clase base, con las abstracciones requeridas para la implementación de las REST APIs.
  - Se crea una clase para el manejo de las configuraciones (appsettings.json).
  - Se crea una implementación básica para la autorización de los usuarios con API Keys.
  - [Instructivo con el paso a paso](https://tinyurl.com/2p8c4vwp)
 
### [:] Proyecto de tipo WebApi como punto de entrada (Gateway) para las APIs.
  - Adicionamos y configuramos el Servicio del Reverse Proxy (Yarp Server), que cumplirá el papel de puerta de enlace (Gateway), y nos ayudará a reforzar la seguridad, garantizar la escalabilidad y la alta disponibilidad.
  - Adicionamos y configuramos con Bearer Token el Servicio de Autenticación
  - Adicionamos y configuramos las políticas del Servicio de Autorización.
  - Adicionamos y configuramos el Servicio de RateLimiter, para garantizar que el Servidor permanezca disponible para todos los usuarios y que su rendimiento no se vea afectado negativamente por un tráfico excesivo.
  - Crearemos el HealthCheck para validar la disponibilidad del Servicio.
  - Crearemos el HealthCheck para validar la disponibilidad de la Base de Datos MongoDB.
  - Instructivo con el paso a paso -> ( Próximamente )
 
### [:] Proyecto de tipo WebApi con el CRUD para atender las solicitudes de Productos.
  - Adicionamos y configuramos el Servicio para el Versionamiento de las APIs y sus endpoints.
  - Configuramos el proyecto para el manejo de los datos sensibles en los archivos de configuración.
  - Se cree la clase Controller para implementar las APIs.
  - Creamos y configuramos los Endpoints de las APIs para exponerlos.
  - Creamos los Secrets con los datos sensibles del proyecto.
  - Adicionamos al proyecto las instancias Singleton para el acceso a la BD, y la validación de las API Keys.
  - Adicionamos y mapeamos los Servicios de HealthCheck del Servicio y la BD.
  - Adicionamos y mapeamos el Servicio de RateLimiter.
  - Instructivo con el paso a paso -> ( Próximamente )

### [:] Implementar configuraciones adicionales en la Solución.
  - Habilitar el Certificado de Desarrollo para las APIs.
  - Inhabilitar la ejecución de la Solución directamente en el Explorador.
  - Configurar el proyecto por defecto de la Solución.
  - Configurar la WebApi (Gateway), creada anteriormente, para enrutar las solicitudes al Servicio correspondiente.
  - Instructivo con el paso a paso -> ( Próximamente )

### [:] Instalación y configuración del Docker.
  - Instalación del Docker Desktop, correspondiente al Sistema Operativo.
  - Inicialización del proyecto con los archivos básicos para Contenerizar las APIs con Docker.
  - Ajustar los proyectos de la Solución para Contenerizar las APIs por separado.
  - Instructivo con el paso a paso -> ( Próximamente )

### [:] Implementar el despliegue de la Solución con Docker.
  - Creación del archivo "Compose.yaml" para crear y desplegar los contenedores de las APIs.
  - Configurar el archivo "Compose.yaml" para desplegar varios contenedores.
  - Configuraciones requeridas para el contenedor del API Gateway.
  - Configurar las variables de entorno requeridas por cada Servicio en el contenedor.
  - Configurar de manera segura las variables de entorno que contienen datos sensibles.
  - Instructivo con el paso a paso -> ( Próximamente )

---------

[**YouTube**](https://www.youtube.com/@hectorgomez-backend-dev/featured) - 
[**LinkedIn**](https://www.linkedin.com/in/hectorgomez-backend-dev/)
