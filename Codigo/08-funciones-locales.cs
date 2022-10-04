using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    internal class _08_funciones_locales {
        public void funcionesLocales() {
            void imprimeResultado(int cantidad) {
                Console.WriteLine($"El valor es: { cantidad }");
            }

            void sumarValores(int a, int b) {
                int suma = a + b;
                imprimeResultado(suma);
            }

            sumarValores(10, 2);

            int multiplicar(int a, int b) => a * b;
        }
    }
}
