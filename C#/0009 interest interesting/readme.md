Introducción
Números de punto flotante
Un número de coma flotante es un número con cero o más dígitos detrás del separador decimal. Algunos ejemplos son -2.4, 0.1, y .3.1416.9840251024.0

Diferentes tipos de punto flotante pueden almacenar diferentes números de dígitos después del separador de dígitos; esto se conoce como precisión.

C# tiene tres tipos de punto flotante:

float: 4 bytes (precisión de ~6-9 dígitos). Escrito como 2.45f.
double: 8 bytes (precisión de ~15-17 dígitos). Este es el tipo más común. Escrito como 2.45o 2.45d.
decimal: 16 bytes (precisión de 28-29 dígitos). Normalmente se utiliza cuando se trabaja con datos monetarios, ya que su precisión conduce a menos errores de redondeo. Escrito como 2.45m.
Como puede verse, cada tipo puede almacenar un número diferente de dígitos. Esto significa que al intentar almacenar PI en a floatsolo se almacenarán los primeros 6 a 9 dígitos (redondeando el último dígito).

Mientras bucles
En este ejercicio es posible que también quieras utilizar un bucle. Hay varias formas de escribir bucles en C#, pero el whilebucle es más apropiado aquí:

int x = 23;

while (x > 10)
{
    // Execute logic if x > 10
    x = x - 2;
}
Hacer bucles while
Una alternativa menos utilizada a la sintaxis anterior es un do-whilebucle:

int x = 23;

do
{
    // Execute logic if x > 10
    x = x - 2;
} while (x > 10)
Instrucciones
En este ejercicio trabajará con cuentas de ahorro. Cada año, el saldo de su cuenta de ahorros se actualiza en función de su tasa de interés. La tasa de interés que le otorga su banco depende de la cantidad de dinero en su cuenta (su saldo):

3,213% para un saldo negativo (el saldo se vuelve más negativo).
0,5% para un saldo positivo inferior a 1000dólares.
1,621% para saldo positivo mayor o igual a 1000dólares y menor a 5000dólares.
2,475% para saldo positivo mayor o igual a 5000dólares.
Tiene cuatro tareas, cada una de las cuales se ocupará de su saldo y su tasa de interés.

1. Calcular la tasa de interés
Implemente el método ( estático ) SavingsAccount.InterestRate()para calcular la tasa de interés en función del saldo especificado:

SavingsAccount.InterestRate(balance: 200.75m)
// 0.5f
Tenga en cuenta que el valor devuelto es float.

2. Calcula el interés
Implemente el método ( estático ) SavingsAccount.Interest()para calcular el interés en función del saldo especificado:

SavingsAccount.Interest(balance: 200.75m)
// 1.00375m
Tenga en cuenta que el valor devuelto es decimal.

3. Calcular la actualización del balance anual
Implementar el método ( estático ) SavingsAccount.AnnualBalanceUpdate()para calcular la actualización del saldo anual, teniendo en cuenta la tasa de interés:

SavingsAccount.AnnualBalanceUpdate(balance: 200.75m)
// 201.75375m
Tenga en cuenta que el valor devuelto es decimal.

4. Calcula los años antes de alcanzar el equilibrio deseado.
Implemente el método ( estático ) para calcular la cantidad mínima de años necesarios para alcanzar el saldo deseado dado el interés compuesto anual:SavingsAccount.YearsBeforeDesiredBalance()

SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m)
// 14
Tenga en cuenta que el valor devuelto es un int.

Nota
Al aplicar el interés simple a un saldo de capital, el saldo se multiplica por la tasa de interés y el producto de los dos es el monto del interés.

El interés compuesto, por otro lado, se obtiene aplicando intereses de forma recurrente. En cada solicitud, el monto del interés se calcula y se suma al saldo de capital para que los cálculos de intereses posteriores estén sujetos a un saldo de capital mayor.