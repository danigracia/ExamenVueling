# Examen Vueling Daniel Gracia
## Introducci�n
El proyecto se basa en una web api que recibe datos de otra web api y los trata para dar unos resultados. En este proyecto utilizaremos 
* Redis para la persistencia.
* WebApi de forma sincrona.
* AutoFac integrado con webapi.
* Versionado de API.
* Swagger documentaci�n de metodos de los controladores.
* Log4net con adapter pattern.
* Arquitectura de 3 capas.
* DDD.
* Utiliza variables de entorno para saber que framework de log escoger, aunque solo he implementado log4net, lo dejo preparado pensando en cambios futuros.
* Tambien utiliza appSettings key/value por el archivo de web.config.

## Arquitectura
Para desarrollar este proyecto he utilizado la arquitectura de 3 capas, y una peque�a parte de DDD(Domain Driven Design).
* Capa de Negocio.
* Capa de Acceso a datos.
* Capa de Presentacion.(En este caso esta capa no la hemos utilizado ya que al ser una web api no estamos utilizando un cliente. Y este hace que cualquier 
  capa de presentaci�n que utlize bien los metodos puede implementa los controladores podria usar la web api.
* Capa Comun.
* DDD - Implementando la separaci�n de las interfaces de los clases que implementan los metodos de estas.

## Redis para la persistencia
Redis esta deployado en un docker, al cual se conecta la wep api para guardar datos y poder hacer persistencia de datos. 
Aparte Redis tiene persistencia de datos en disco por si mismo.

## Swagger 
Uno de los mayores problemas de las APIs es que en muchos casos, la documentaci�n que les acompa�a es in�til. Con Swagger solucionamos este problema,
porque te da un listado de todos los metodos del controlador, en caso de tener varios controladores te separa los metodos por controlador. Tambien 
puedes hacer pruebas con los metodos desde su interfaz web.

## Log4net
Para debuggar en un archivo de logs la traza de todo el recorrido de la aplicaci�n y si surge algun fallo que quede registrado.

## Recursos
Archivos de recursos para agregar mensajes personalizados al log por ejemplo.

