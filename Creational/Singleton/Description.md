# Singleton Pattern

El patron de diseño singleton hace parte de grupo de los patrones creacionales.

### Puntos a resaltar:

- Solo se crea una instancia de la clase
- Acceso global a esa instancia de clase
- Activa el tiempo de vida de la aplicación

### Desventajas

- Pocos seguras porque permite reescritura de la instancia

### Example
![image](https://github.com/IbarraOrtizDev/DesignPatterns/assets/39393685/5185a9d4-ae54-4636-8b8a-9e423cb7ac12)


### Cuando implementar Singleton Thead Safe

Se utiliza cuando hay concurrencia y se quiere evitar que se creen multiples instancias del singleton ya que se puede dar que cuando ingresen todas los hilos al metodo getInstance de forma tradicional _instance este null y por eso permita la creanción de multiples instancias de manera paralela, es por ello es que implmenta look, ya que es una manera de frenar los hilos y darles tiempo de que cada uno ingrese de manera secuencial a esa seccion del código
