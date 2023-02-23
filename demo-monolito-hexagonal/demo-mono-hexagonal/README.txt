#Capa de dominio

- Todo el dominio puede ser convertido en APIs / Microservicios
- Considerar que el log y notificaciones pueden estar en una db no relacional como MongoDB, para esto es ideal tener 2 db, una de lectura 
y otra de escritura, as� no saturas la db transaccional
- Cada uno de estos proyectos al ser una API puede vivir de forma independiente en Docker
- El proyecto dominio.core es un proyecto en donde agregues los procesos que sean transversal y m�s importantes
- Tambi�n puedes utilizar el Patron CQRS para la lectura y escritura


#Capa de Infraestructura

En esta capa van los conectores a cualquier origen de datos, considerar que en un futuro al usar EF es posible separar por contexto la db, por lo cual
no es necesario importar todo el modelo a la migraci�n futura de APIs, ver la posibilidad de hacerlo hoy en d�a separado para que el impacto en el 
futuro sea lo menor posible


#Consideraciones generales

- La soluci�n considera LOG nativo para la gesti�n y traza de errores por lo tanto no es necesario agregar librerias adicionales
- La soluci�n considera la utilizaci�n de Inyecci�n de dependencias, por ning�n motivo utilizar NEW para la incializaci�n de clases
- El middleware est� configurado con Swagger
- En la capa de infraestructura si bien debe existir un solo contexto, ese contexto en el futuro si se migran las apis, est�s deben tener un contexto con las entidades a utilizar.
Lo anterior se puede utilizar separando el modelo en esquemas
- Cada dominio debe tener su propio negocio y utilidades, por lo cual no pueden compartir reglas o utilidades
- Base de datos a utilizar en este demo es PostgreSQL
- La soluci�n de API no considera Docker, pero si se debe considerar en una futura migraci�n