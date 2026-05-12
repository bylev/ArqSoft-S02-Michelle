# Ahorcado 

Un juego sencillo escrito en C#

---

# Identificar las violaciones SOLID

| Situación | Principio violado |
| --- | --- | --- | --- | ---   |
| *Juego* controla turnos, dibuja el tablero, muestra mensajes,
y elige la palabra | Single Responsability Principle (SRP) |
| --- | --- | ---| --- | ---    |
| Las palabras están hardcodeadas dentro del constructor | Dependency Inversion Principle (DIP) |
| --- | --- | ---| --- | ---    |
| Para agregar un segundo juego habría que modificar *Juego* directamente | Open/Closed Principle (OCP) |

---