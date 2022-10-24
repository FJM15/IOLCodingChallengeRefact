
# Detalle de la refactorización

### Diseño de la solución

Se dividió la solución en capas (Entidades, Datos y Negocio) con el objetivo de dividir las responsabilidades y obtener como resultado un desarrollo limpio, escalable y mantenible. 

### Figuras geométricas

En la capa de Entidades, se rediseñó la estructura de clases para la creación de figuras geométricas basando el diseño en el patrón Strategy, definiendo de esta forma una Interfaz "IFormaGeometrica" con la declaración de los métodos CalcularArea y CalcularPerimetro a implementar por cada figura. 

Se crearon las clases para cada figura, y se implementó el contrato "IFormaGeometrica" en cada una de ellas.

Por otro lado, para algunas figuras particulares como por ejemplo los trapecios, que cuentan con más de un tipo, se generó una clase abstracta con las propiedades del mismo y la definición del método CalcularArea que es el mismo para todos los tipos de trapecios, quedando la definición del método CalcularPerimetro como responsabilidad de cada clase particular (TrapecioIsosceles y TrapecioRectangulo en este caso).

Finalmente, en la capa de Negocio, la clase FormaGeometricaContexto encargada de la creación de las figuras geométricas permite la instanciación de las mismas a partir de distintos parámetros de entrada, pudiéndose de esta forma por ejemplo crear un círculo a partir del radio o bien del diámetro del mismo:

```csharp
var obj1 = FormaGeometricaContexto.GenerarCirculo(radio: 3);
var obj2 = FormaGeometricaContexto.GenerarCirculo(diametro: 6);
```

También se segregaron en la capa de Negocio los servicios de reportería, separando la responsabilidad de cálculo y armado del reporte.

### Idiomas

Para permitir la generación del reporte en múltiples idiomas, queda del lado de la capa de Datos la responsabilidad del acceso a las traducciones. Para esto se creó una interfaz “ITraductor” que define el contrato que deben cumplir los distintos métodos de traducción (Recursos, Json, API, Base de Datos, etc). 

En este caso, se generaron recursos para cada idioma con todas las traducciones y la lectura de los mismos se logra con el seteo de la cultura del usuario (CurrentUICulture), que se establece para cada hilo en el momento de la generación del reporte, y se revierte al terminar esta tarea. 

También se crearon clases en la carpeta Tools que definen los idiomas existentes y cuentan con los métodos para setear y revertir las distintas culturas.

### Conclusión

Se llevó a cabo la refactorización del código siguiendo principios y buenas prácticas de programación para obtener como resultado un código limpio, escalable y mantenible. 
La generación de nuevas figuras geométricas solo requiere la creación una clase para la misma en la capa de Entidades, que implemente la interfaz IFormaGeometrica, y la creación del método para su instanciación en FormaGeometricaContexto, en la capa de Negocio.
Por otro lado, se pueden agregar nuevos idiomas con solo generar el recurso con las traducciones en el directorio Resources de la capa de Datos, y agregando esta nueva entrada en la clase Culturas de la capa de Entidades.

**Gracias.**
