var repositorio = new Ahorcado.PalabrasEnMemoria();
var motor = new Ahorcado.MotorAhorcado(repositorio);
var ui = new Ahorcado.ConsolaUI(motor);

Console.WriteLine("=== AHORCADO ===");

while (!motor.Ganado() && !motor.Perdido())
{
    ui.MostrarTablero();
    ui.MostrarPista();
    char letra = ui.PedirLetra();
    if (motor.LetraYaUsada(letra))
    {
        ui.MostrarMensaje("Ya usaste esa letra.");
        continue;
    }
    motor.RegistrarLetra(letra);
}
ui.MostrarTablero();

if(motor.Ganado())
    ui.MostrarMensaje("\n¡Ganaste! La palabra era: " + motor.PalabraSecreta);
else
    ui.MostrarMensaje("\n¡Perdiste! La palabra era: " + motor.PalabraSecreta);

if(ui.PreguntarOtraVez())
{
    var nuevoMotor = new Ahorcado.MotorAhorcado(repositorio);
    var nuevaUI = new Ahorcado.ConsolaUI(nuevoMotor);
    while (!nuevoMotor.Ganado() && !nuevoMotor.Perdido())
    {
        nuevaUI.MostrarTablero();
        char letra = nuevaUI.PedirLetra();
        if (nuevoMotor.LetraYaUsada(letra))
        {
            nuevaUI.MostrarMensaje("Ya usaste esa letra.");
            continue;
        }
        nuevoMotor.RegistrarLetra(letra);
    }
    nuevaUI.MostrarTablero();
    if(nuevoMotor.Ganado())
        nuevaUI.MostrarMensaje("\n¡Ganaste! La palabra era: " + nuevoMotor.PalabraSecreta);
    else
        nuevaUI.MostrarMensaje("\n¡Perdiste! La palabra era: " + nuevoMotor.PalabraSecreta);
}

if (ui.PreguntarOtraVez())
{
    var nuevoMotor = new Ahorcado.MotorAhorcado(repositorio);
    var nuevaUI = new Ahorcado.ConsolaUI(nuevoMotor);
}