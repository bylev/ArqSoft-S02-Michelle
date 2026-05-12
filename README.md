# Ahorcado 

Un juego sencillo escrito en C#

---

# Identificar las violaciones SOLID

| Situación | Principio violado |
| --- | --- |
| *Juego* controla turnos, dibuja el tablero, muestra mensajes  elige la palabra | Single Responsability Principle (SRP) |
| Las palabras están hardcodeadas dentro del constructor | Dependency Inversion Principle (DIP) |
| Para agregar un segundo juego habría que modificar *Juego* directamente | Open/Closed Principle (OCP) |

---

# Refactorizar el código para cumplir con SOLID

Se agregó la interfaz *IRepositorioPalabras* para abstraer la fuente de las palabras, y se creó una clase *RepositorioPalabras* que implementa esta interfaz. La clase *Juego* ahora depende de la interfaz en lugar de una implementación concreta, lo que cumple con el principio de inversión de dependencias (DIP). Esta interfaz
es el contrato, y la clase *RepositorioPalabras* es la implementación concreta. Esto permite que el código sea más flexible y fácil de mantener, ya que se pueden agregar nuevas fuentes de palabras sin modificar la clase *Juego* para resolver
Open/Closed Principle (OCP).

---

# Refactorización del motor del juego

MotorAhorcado no tiene ni una línea de Console. Solo sabe jugar lo que resuelve Single Responsability Principle (SRP).

---

# Refactorización de la interfaz de usuario

La interfaz de usuario se ha separado del motor del juego, lo que permite una mayor flexibilidad y mantenibilidad. La clase *InterfazUsuario* es responsable de interactuar con el usuario, mostrar mensajes y dibujar el tablero, mientras que la clase *Juego* se encarga de la lógica del juego. Esto cumple con el principio de responsabilidad única (SRP) y permite que la interfaz de usuario pueda ser modificada o mejorada sin afectar la lógica del juego.

--- 

# Agregar un nuevo juego
Para agregar un nuevo juego, se puede crear una nueva clase que implemente la interfaz *IJuego* y luego modificar la clase *InterfazUsuario* para permitir al usuario seleccionar el juego que desea jugar. Esto se puede hacer sin modificar la clase *Juego*, lo que cumple con el principio de abierto/cerrado (OCP). De esta manera, se pueden agregar nuevos juegos sin afectar el código existente, lo que mejora la mantenibilidad y escalabilidad del proyecto.

---

# Agregar Método de MostrarPistas

Agregué un método en la ConsolaUI en donde se hace un if-else que ve si los intentos restantes son 3, te imprime
un mensaje diciendo con que letra empieza la palabra. Y se llama en el while de Program.cs ya que es donde está el flujo
del juego.

---

# Funcionamiento

![image](C:\Users\wonho\source\repos\Ahorcado\images\ss1.png)
![image](C:\Users\wonho\source\repos\Ahorcado\images\ss2.png)


