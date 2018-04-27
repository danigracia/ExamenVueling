# Examen Vueling Daniel Gracia

## Introducción
El proyecto se basa en una web api que recibe datos de otra web api y los trata para dar unos resultados. En este proyecto utilizaremos 
* Redis para la persistencia.
* Solid.
* WebApi de forma sincrona.
* AutoFac integrado con webapi.
* Versionado de API.
* Swagger documentación de metodos de los controladores.
* Log4net con adapter pattern.
* Arquitectura de 3 capas.
* DDD.
* Utiliza variables de entorno para saber que framework de log escoger, aunque solo he implementado log4net, lo dejo preparado pensando en cambios futuros.
* Tambien utiliza appSettings key/value por el archivo de web.config.

## Arquitectura
Para desarrollar este proyecto he utilizado la arquitectura de 3 capas, y una pequeña parte de DDD(Domain Driven Design).
* Capa de Negocio.
* Capa de Acceso a datos.
* Capa de Presentacion.(En este caso esta capa no la hemos utilizado ya que al ser una web api no estamos utilizando un cliente. Y este hace que cualquier 
  capa de presentación que utlize bien los metodos puede implementa los controladores podria usar la web api.
* Capa Comun.
* DDD - Implementando la separación de las interfaces de los clases que implementan los metodos de estas.

## Redis para la persistencia
Redis esta deployado en un docker, al cual se conecta la wep api para guardar datos y poder hacer persistencia de datos. 
Aparte Redis tiene persistencia de datos en disco por si mismo.

## Swagger 
Uno de los mayores problemas de las APIs es que en muchos casos, la documentación que les acompaña es inútil. Con Swagger solucionamos este problema,
porque te da un listado de todos los metodos del controlador, en caso de tener varios controladores te separa los metodos por controlador. Tambien 
puedes hacer pruebas con los metodos desde su interfaz web.

## Log4net
Para realizar el log en un archivo de logs la traza de todo el recorrido de la aplicación y si surge algun fallo que quede registrado.

## Recursos
Archivos de recursos para agregar mensajes personalizados al log por ejemplo.

## Logica 
No me ha dado tiempo a realizarla, pero si la he planteado. Cuando yo recibo los datos del Rates, el patron se basa en:
primer que siempre tienes 4 tipos de monedas diferentes. La primera conversión siempre es de Moneda 1 a Moneda 2, la segunda de Moneda 2 a Moneda 1, la tercera de la Moneda 1 a la Moneda 3,  la cuarta de la Moneda 3 a la Moneda 1, la quinta de la Moneda 2 a la Moneda 4, y la ultima de Moneda 4 a la Moneda 2.
  
El calculo de la propina es multiplicar el amount por 0.05. Luego ya utilizar el patron de conversion.



