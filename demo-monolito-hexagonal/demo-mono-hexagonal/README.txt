#Capa de dominio

- Todo el dominio puede ser convertido en APIs / Microservicios
- Considerar que el log y notificaciones pueden estar en una db no relacional como MongoDB, para esto es ideal tener 2 db, una de lectura 
y otra de escritura, así no saturas la db transaccional
- Cada uno de estos proyectos al ser una API puede vivir de forma independiente en Docker
- El proyecto dominio.core es un proyecto en donde agregues los procesos que sean transversal y más importantes
- También puedes utilizar el Patron CQRS para la lectura y escritura


#Capa de Infraestructura

En esta capa van los conectores a cualquier origen de datos, considerar que en un futuro al usar EF es posible separar por contexto la db, por lo cual
no es necesario importar todo el modelo a la migración futura de APIs, ver la posibilidad de hacerlo hoy en día separado para que el impacto en el 
futuro sea lo menor posible


#Consideraciones generales