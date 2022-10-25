
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

Se desarrolló a modo "Lógica de Negocio" la posibilidad de recibir parámetros en cero o negativos para la creación de figuras geométricas. Ante parámetros negativos se tomará el valor absoluto del mismo, mientras que para parámetros en cero se aceptarán como tal y los cálculos se llevarán a cabo en estos valores.

También se segregaron en la capa de Negocio los servicios de reportería, separando la responsabilidad de cálculo y armado del reporte.

### Idiomas

Para permitir la generación del reporte en múltiples idiomas, queda del lado de la capa de Datos la responsabilidad del acceso a las traducciones. Para esto se creó una interfaz “ITraductor” que define el contrato que deben cumplir los distintos métodos de traducción (Recursos, Json, API, Base de Datos, etc). 

En este caso, se generaron recursos para cada idioma con todas las traducciones y la lectura de los mismos se logra con el seteo de la cultura del usuario (CurrentUICulture), que se establece para cada hilo en el momento de la generación del reporte, y se revierte al terminar esta tarea. 

También se crearon clases en la carpeta Tools que definen los idiomas existentes y cuentan con los métodos para setear y revertir las distintas culturas.

### Tests

Se dividieron los test en tres grupos para valir los distintos puntos principales a controlar:
- Tests de Cálculos: Apunta a validar el correcto cálculo de áreas y perímetros de las figuras geométricas existentes.
- Tests de Idiomas: Apunta a validar la correcta traducción del reporte en cada uno de los idiomas configurados.
- Tests de Parámetros: Apunta a controlar el correcto cálculo de áreas y perímetros ante la creación de figuras geométricas con parámetros en cero o negativos.

### Conclusión

Se llevó a cabo la refactorización del código siguiendo principios y buenas prácticas de programación para obtener como resultado un código limpio, escalable y mantenible. 

La generación de nuevas figuras geométricas solo requiere la creación una clase para la misma, que implemente la interfaz IFormaGeometrica, y la creación del método para su instanciación en el contexto (FormaGeometricaContexto). A su vez, se debe agregar la traducción del nombre de la nueva figura en los recursos de idioma para cada cultura y en el default en el proyecto de Datos. La traducción para una nueva figura requiere el agregado de dos traducciones en estos archivos, una para singular y otra para plural, con las claves *nombre_clase_figura_geométrica_en_minúscula*_s y *nombre_clase_figura_geométrica_en_minúscula*_p respectivamente.

Por otro lado, se pueden agregar nuevos idiomas con solo generar el recurso con las traducciones en el directorio Resources, y agregando esta nueva entrada en la clase Culturas. Si se agregan nuevos idiomas en la clase Cultura pero no se crean los recursos para las traducciones, se hará uso del recurso por defalt *Language.resx*.

**Gracias.**
