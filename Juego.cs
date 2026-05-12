using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    internal class Juego
    {
        private List<String> _palabras = new()
        {
            "arquitectura", "interfaz", "polimorfismo",
            "encapsulamiento", "herencia"
        };

        private string _palabraSecreta;
        private List<char> _letrasUsadas;
        private int _intentosRestantes;

        public Juego()
        {
            var random = new Random();
            _palabraSecreta = _palabras[random.Next(_palabras.Count)];
            _letrasUsadas = new List<char>();
            _intentosRestantes = 6;
        }

        public void Jugar()
        {
            Console.Clear();
            Console.WriteLine("=== AHORCADO ===");

            while (_intentosRestantes > 0)
            {
                MostrarTablero();
                if (VerificarVictoria())
                {
                    Console.WriteLine("\n¡Ganaste! La palabra era: " + _palabraSecreta);
                    Console.Write("\n¿Jugar otra vez? (s/n): ");
                    if (Console.ReadLine()?.ToLower() == "s")
                        new Juego().Jugar();
                    return;
                }
                Console.Write("\nIngresa una letra: ");
                string? entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada) || entrada.Length == 0)
                {
                    Console.WriteLine("Debes ingresar una letra.");
                    continue;
                }

                char letra = char.ToLower(entrada[0]);

                if (!char.IsLetter(letra))
                {
                    Console.WriteLine("Solo se aceptan letras. Intenta de nuevo.");
                    continue;
                }

                if (_letrasUsadas.Contains(letra))
                {
                    Console.WriteLine("Ya usaste esa letra. Intenta con otra.");
                    continue;
                }
                _letrasUsadas.Add(letra);
                if (!_palabraSecreta.Contains(letra))
                    _intentosRestantes--;

            }

            MostrarTablero();
            Console.WriteLine("\n¡Perdiste! La palabra era: " + _palabraSecreta);
            Console.Write("\n¿Jugar otra vez? (s/n): ");
            if (Console.ReadLine()?.ToLower() == "s")
                new Juego().Jugar();
        }

        private bool VerificarVictoria()
        {
            foreach (char letra in _palabraSecreta)
            {
                if (!_letrasUsadas.Contains(letra))
                    return false;
            }
            return true;
        }
        private void MostrarTablero()
        {
            Console.Clear();

            MostrarAhorcado();

            Console.WriteLine($"Intentos restantes: {_intentosRestantes}");
            Console.WriteLine($"Letras usadas: {string.Join(", ", _letrasUsadas)}");

            Console.Write("Palabra: ");

            foreach (char c in _palabraSecreta)
            {
                Console.Write(_letrasUsadas.Contains(c) ? c : '_');
            }

            Console.WriteLine();
        }

        private void MostrarAhorcado()
        {
            string[] etapas = new string[]
            {
        "-----\n |   |\n     |\n     |\n     |\n     |\n=========",

        "-----\n |   |\n O   |\n     |\n     |\n     |\n=========",

        "-----\n |   |\n O   |\n |   |\n     |\n     |\n=========",

        "-----\n |   |\n O   |\n/|   |\n     |\n     |\n=========",

        "-----\n |   |\n O   |\n/|\\  |\n     |\n     |\n=========",

        "-----\n |   |\n O   |\n/|\\  |\n/    |\n     |\n=========",

        "-----\n |   |\n O   |\n/|\\  |\n/ \\  |\n     |\n========="
            };

            int indice = Math.Min(6 - _intentosRestantes, etapas.Length - 1);
            Console.WriteLine(etapas[indice]);
        }

        private void Pistas()
        {
            Console.WriteLine("Pista: La palabra tiene " + _palabraSecreta.Length + " letras.");
            if(_intentosRestantes == 3)
                Console.WriteLine("Pista: La palabra empieza con '" + _palabraSecreta[0] + "'.");
        }
    }
}


