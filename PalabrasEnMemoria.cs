using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    internal class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly List<String> _palabras = new()
        {
            "arquitectura", "interfaz", "polimorfismo",
            "encapsulamiento", "herencia"
        };

        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();
            return _palabras[random.Next(_palabras.Count)];
        }
    }
}
