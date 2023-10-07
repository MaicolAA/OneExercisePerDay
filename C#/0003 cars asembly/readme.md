Introducción
Números
Hay dos tipos diferentes de números en C#:

Enteros: números sin dígitos detrás del separador decimal (números enteros). Algunos ejemplos son -6, 0, 1, 25y 976.500000
Números de coma flotante: números con cero o más dígitos detrás del separador decimal. Algunos ejemplos son -2.4, 0.1, 3.14y 16.984025.1024.0
Los dos tipos numéricos más comunes en C# son inty double. An intes un número entero de 32 bits y a doublees un número de punto flotante de 64 bits.

La aritmética se realiza utilizando los operadores aritméticos estándar. Los números se pueden comparar utilizando los operadores de comparación numérica estándar y los operadores de igualdad ( ==) y desigualdad ( ).!=

C# tiene dos tipos de conversiones numéricas:

Conversiones implícitas: no se perderán datos y no se requiere sintaxis adicional.
Conversiones explícitas: se podrían perder datos y se requiere sintaxis adicional en forma de conversión .
Como an inttiene menos precisión que a double, la conversión de an inta a doublees segura y, por lo tanto, es una conversión implícita. Sin embargo, convertir de a doublea an intpodría significar la pérdida de datos, por lo que requiere una conversión explícita.

Si declaraciones
En este ejercicio debes ejecutar la lógica de forma condicional. La forma más común de hacer esto en C# es mediante una if/elsedeclaración:

int x = 6;

if (x == 5)
{
    // Execute logic if x equals 5
}
else if (x > 7)
{
    // Execute logic if x greater than 7
}
else
{
    // Execute logic in all other cases
}
La condición de una ifdeclaración debe ser de tipo bool. C# no tiene ningún concepto de valores veraces .

Instrucciones
En este ejercicio escribirás código para analizar la producción de una línea de montaje en una fábrica de automóviles. La velocidad de la línea de montaje puede variar de 0(apagado) a 10(máximo).

A su velocidad más baja ( 1), 221los automóviles se producen cada hora. La producción aumenta linealmente con la velocidad. Entonces, con la velocidad establecida en 4, debería producir 4 * 221 = 884automóviles por hora. Sin embargo, las velocidades más altas aumentan la probabilidad de que se produzcan coches defectuosos que luego tengan que ser desechados.

Tienes tres tareas.

1. Calcule la tasa de éxito
Implemente el método ( estático ) AssemblyLine.SuccessRate()para calcular la proporción de un elemento que se crea sin error para una velocidad determinada. La siguiente tabla muestra cómo la velocidad influye en la tasa de éxito:

0: 0% de tasa de éxito.
1a 4: tasa de éxito del 100%.
5a 8: 90% de tasa de éxito.
9: 80% de tasa de éxito.
10: Tasa de éxito del 77%.
AssemblyLine.SuccessRate(10)
// => 0.77
2. Calcule la tasa de producción por hora.
Implemente el método ( estático ) AssemblyLine.ProductionRatePerHour()para calcular la tasa de producción por hora de la línea de montaje, teniendo en cuenta su tasa de éxito:

AssemblyLine.ProductionRatePerHour(6)
// => 1193.4
Tenga en cuenta que el valor devuelto es double.

3. Calcule la cantidad de elementos de trabajo producidos por minuto.
Implemente el método ( estático ) AssemblyLine.WorkingItemsPerMinute()para calcular cuántos automóviles en funcionamiento se producen por minuto:

AssemblyLine.WorkingItemsPerMinute(6)
// => 19
Tenga en cuenta que el valor devuelto es un int.