# Solución WebApi con .NET 8, MongoDB, y contenerizada con Docker

Esta es una solución desarrollada en Visual Studio Code, con .NET 8, MongoDB, y Docker. Ésta la estamos implementando paso a paso en una serie de videos que se están publicando en mi canal de YouTube -> https://tinyurl.com/42x8zvyv

La solución incluye la siguiente funcionallidad:

* Proyecto de tipo ClassLib que nos permitirá realizar la conexión a una Base de Datos de MongoDB.
  - Se crea la clase para realizar la conexión a MongoDB.
  - Se crean los modelos para definir las colecciones en la BD.
  - Se crean los DTO's (Data Transfer Objects) para intercambiar información con el FrontEnd.
  - Instructivo con el paso a paso -> https://tinyurl.com/3cvzyzud
    
* Proyecto de tipo ClassLib como base para implementar las REST APIs.
  - Se crea una clase base, con las abstracciones requeridas para la implementación de las REST APIs.
  - Se crea una clase para el manejo de las configuraciones (appsettings.json).
  - Se crea una implementación básica para la autorización de los usuarios con API Keys.
  - Instructivo con el paso a paso -> https://tinyurl.com/2p8c4vwp
 
* Proyecto de tipo WebApi como punto de entrada (Gateway) para las APIs.
  - Adicionamos y configuramos el Servicio del Reverse Proxy (Yarp Server), que cumplirá el papel de puerta de enlace (Gateway), y nos ayudará a reforzar la seguridad, garantizar la escalabilidad y la alta disponibilidad.
  - Adicionamos y configuramos con Bearer Token el Servicio de Autenticación
  - Adicionamos y configuramos las políticas del Servicio de Autorización.
  - Adicionamos y configuramos el Servicio de RateLimiter, para garantizar que el Servidor permanezca disponible para todos los usuarios y que su rendimiento no se vea afectado negativamente por un tráfico excesivo.
  - Crearemos el HealthCheck para validar la disponibilidad del Servicio.
  - Crearemos el HealthCheck para validar la disponibilidad de la Base de Datos MongoDB.
  - Instructivo con el paso a paso -> ( Próximamente )
 
* Proyecto de tipo WebApi con el CRUD para atender las solicitudes de Productos.
  - 
