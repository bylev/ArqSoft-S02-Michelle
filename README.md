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