using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    internal class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly List<(string palabra, string categoria)> _palabras = new()
        {
            ("arquitectura", "Programación"),
            ("interfaz", "Programación"),
            ("polimorfismo", "Programación"),
            ("encapsulamiento", "Programación"),
            ("herencia", "Programación"),
            ("gato", "Animales"),
            ("perro", "Animales"),
            ("elefante", "Animales"),
            ("españa", "Países"),
            ("brasil", "Países"),
            ("japón", "Países")
        };

        private string _palabraActual;

        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();
            var tupla = _palabras[random.Next(_palabras.Count)];
            _palabraActual = tupla.palabra;
            return tupla.palabra;
        }

        public string ObtenerCategoria()
        {
            return _palabras.First(p => p.palabra == _palabraActual).categoria;
        }
    }
}
