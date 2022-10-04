using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _11_predicados {
        public void predicados() {
            bool esPar(int num) {
                return num % 2 == 0;
            }

            Predicate<int> predicado = esPar;

            var valor = 5;
            Console.WriteLine($"¿Es { valor } par? { predicado(valor) }");

            var valor2 = 6;
            Console.WriteLine($"¿Es { valor2 } par? { predicado(valor2) }");
        }
    }
}
