Introducción
Clases
La principal construcción orientada a objetos en C# es la clase , que es una combinación de datos ( campos ) y comportamiento ( métodos ). Los campos y métodos de una clase se conocen como sus miembros .

El acceso a los miembros se puede restringir mediante modificadores de acceso, siendo los dos más comunes:

public: se puede acceder al miembro mediante cualquier código (sin restricciones).
private: solo se puede acceder al miembro mediante código en la misma clase.
Puedes pensar en una clase como una plantilla para crear instancias de esa clase. Para crear una instancia de una clase (también conocida como objeto ), newse utiliza la palabra clave:

class Car
{
}

// Create two car instances
var myCar = new Car();
var yourCar = new Car();
Los campos tienen un tipo y se pueden definir en cualquier lugar de una clase. Los campos públicos se definen en PascalCase y los campos privados se definen en camelCase y tienen el prefijo de guión bajo _:

class Car
{
    // Accessible by anyone
    public int Weight;

    // Only accessible by code in this class
    private string _color;
}
Opcionalmente, se puede asignar un valor inicial a un campo. Si un campo no especifica un valor inicial, se establecerá en el valor predeterminado de su tipo. Se puede acceder a los valores de campo de una instancia y actualizarlos mediante notación de puntos.

class Car
{
    // Will be set to specified value
    public int Weight = 2500;

    // Will be set to default value (0)
    public int Year;
}

var newCar = new Car();
newCar.Weight; // => 2500
newCar.Year;   // => 0

// Update value of the field
newCar.Year = 2018;
Los campos privados generalmente se actualizan como efecto secundario de llamar a un método. Estos métodos normalmente no devuelven ningún valor, en cuyo caso el tipo de retorno debería ser void:

class CarImporter
{
    private int _carsImported;

    public void ImportCars(int numberOfCars)
    {
        // Update private field from public method
        _carsImported = _carsImported + numberOfCars;
    }
}
Instrucciones
En este ejercicio jugarás con un coche controlado a distancia y finalmente has ahorrado suficiente dinero para comprarlo.

Los coches arrancan con las baterías llenas (100%). Cada vez que conduces el coche con el mando a distancia, recorre 20 metros y agota el uno por ciento de la batería.

El automóvil controlado a distancia tiene una elegante pantalla LED que muestra dos bits de información:

La distancia total que ha recorrido, mostrada como: "Driven <METERS> meters".
La carga restante de la batería, mostrada como: "Battery at <PERCENTAGE>%".
Si la batería está al 0%, ya no podrá conducir el automóvil y la pantalla de la batería mostrará "Battery empty".

Tiene seis tareas, cada una de las cuales funcionará con instancias de automóviles controladas remotamente.

1. Compre un automóvil nuevo con control remoto
Implemente el método ( estático ) RemoteControlCar.Buy()para devolver una nueva instancia de automóvil controlado a distancia:

RemoteControlCar car = RemoteControlCar.Buy();
2. Muestra la distancia recorrida.
Implemente el RemoteControlCar.DistanceDisplay()método para devolver la distancia como se muestra en la pantalla LED:

var car = RemoteControlCar.Buy();
car.DistanceDisplay();
// => "Driven 0 meters"
3. Muestra el porcentaje de batería.
Implemente el RemoteControlCar.BatteryDisplay()método para devolver el porcentaje de batería como se muestra en la pantalla LED:

var car = RemoteControlCar.Buy();
car.BatteryDisplay();
// => "Battery at 100%"
4. Actualizar el número de metros recorridos al conducir.
Implementar el RemoteControlCar.Drive()método que actualiza la cantidad de metros recorridos:

var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.DistanceDisplay();
// => "Driven 40 meters"
5. Actualiza el porcentaje de batería al conducir
Actualice el RemoteControlCar.Drive()método para actualizar el porcentaje de batería:

var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.BatteryDisplay();
// => "Battery at 98%"
6. Evite conducir cuando la batería esté agotada
Actualice el RemoteControlCar.Drive()método para no aumentar la distancia recorrida ni disminuir el porcentaje de batería cuando la batería está agotada (al 0%):

var car = RemoteControlCar.Buy();

// Drain the battery
// ...

car.DistanceDisplay();
// => "Driven 2000 meters"

car.BatteryDisplay();
// => "Battery empty"Introducción
Clases
La principal construcción orientada a objetos en C# es la clase , que es una combinación de datos ( campos ) y comportamiento ( métodos ). Los campos y métodos de una clase se conocen como sus miembros .

El acceso a los miembros se puede restringir mediante modificadores de acceso, siendo los dos más comunes:

public: se puede acceder al miembro mediante cualquier código (sin restricciones).
private: solo se puede acceder al miembro mediante código en la misma clase.
Puedes pensar en una clase como una plantilla para crear instancias de esa clase. Para crear una instancia de una clase (también conocida como objeto ), newse utiliza la palabra clave:

class Car
{
}

// Create two car instances
var myCar = new Car();
var yourCar = new Car();
Los campos tienen un tipo y se pueden definir en cualquier lugar de una clase. Los campos públicos se definen en PascalCase y los campos privados se definen en camelCase y tienen el prefijo de guión bajo _:

class Car
{
    // Accessible by anyone
    public int Weight;

    // Only accessible by code in this class
    private string _color;
}
Opcionalmente, se puede asignar un valor inicial a un campo. Si un campo no especifica un valor inicial, se establecerá en el valor predeterminado de su tipo. Se puede acceder a los valores de campo de una instancia y actualizarlos mediante notación de puntos.

class Car
{
    // Will be set to specified value
    public int Weight = 2500;

    // Will be set to default value (0)
    public int Year;
}

var newCar = new Car();
newCar.Weight; // => 2500
newCar.Year;   // => 0

// Update value of the field
newCar.Year = 2018;
Los campos privados generalmente se actualizan como efecto secundario de llamar a un método. Estos métodos normalmente no devuelven ningún valor, en cuyo caso el tipo de retorno debería ser void:

class CarImporter
{
    private int _carsImported;

    public void ImportCars(int numberOfCars)
    {
        // Update private field from public method
        _carsImported = _carsImported + numberOfCars;
    }
}
Instrucciones
En este ejercicio jugarás con un coche controlado a distancia y finalmente has ahorrado suficiente dinero para comprarlo.

Los coches arrancan con las baterías llenas (100%). Cada vez que conduces el coche con el mando a distancia, recorre 20 metros y agota el uno por ciento de la batería.

El automóvil controlado a distancia tiene una elegante pantalla LED que muestra dos bits de información:

La distancia total que ha recorrido, mostrada como: "Driven <METERS> meters".
La carga restante de la batería, mostrada como: "Battery at <PERCENTAGE>%".
Si la batería está al 0%, ya no podrá conducir el automóvil y la pantalla de la batería mostrará "Battery empty".

Tiene seis tareas, cada una de las cuales funcionará con instancias de automóviles controladas remotamente.

1. Compre un automóvil nuevo con control remoto
Implemente el método ( estático ) RemoteControlCar.Buy()para devolver una nueva instancia de automóvil controlado a distancia:

RemoteControlCar car = RemoteControlCar.Buy();
2. Muestra la distancia recorrida.
Implemente el RemoteControlCar.DistanceDisplay()método para devolver la distancia como se muestra en la pantalla LED:

var car = RemoteControlCar.Buy();
car.DistanceDisplay();
// => "Driven 0 meters"
3. Muestra el porcentaje de batería.
Implemente el RemoteControlCar.BatteryDisplay()método para devolver el porcentaje de batería como se muestra en la pantalla LED:

var car = RemoteControlCar.Buy();
car.BatteryDisplay();
// => "Battery at 100%"
4. Actualizar el número de metros recorridos al conducir.
Implementar el RemoteControlCar.Drive()método que actualiza la cantidad de metros recorridos:

var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.DistanceDisplay();
// => "Driven 40 meters"
5. Actualiza el porcentaje de batería al conducir
Actualice el RemoteControlCar.Drive()método para actualizar el porcentaje de batería:

var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.BatteryDisplay();
// => "Battery at 98%"
6. Evite conducir cuando la batería esté agotada
Actualice el RemoteControlCar.Drive()método para no aumentar la distancia recorrida ni disminuir el porcentaje de batería cuando la batería está agotada (al 0%):

var car = RemoteControlCar.Buy();

// Drain the battery
// ...

car.DistanceDisplay();
// => "Driven 2000 meters"

car.BatteryDisplay();
// => "Battery empty"