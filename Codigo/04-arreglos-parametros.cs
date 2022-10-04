using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _04_arreglos_parametros {
        public void funcionesArreglosParametros() {
            double promedio(int[] numeros) {
                var sumar = 0.0;

                foreach (var num in numeros) {
                    sumar += num;
                }

                return sumar / numeros.Length;
            }

            var numSum = new int[] { 12, 1, 22, 3, 4 };

            foreach (var val in numSum) {
                Console.Write($"{ val } ");
            }

            var resultado = promedio(numSum);
            Console.WriteLine($"\nEl promedio es { resultado }");

            double multiplicacion(params int[] numeros) {
                var valor = 1.0;

                foreach (var num in numeros) {
                    valor *= num;
                }

                return valor;
            }

            var numMult = new int[] { 12, 1, 22, 3, 4 };

            foreach (var val in numMult) {
                Console.Write($"{ val } ");
            }

            var resultadoMult = multiplicacion(12, 1, 22, 3, 4);
            Console.WriteLine($"\nLa multiplicación de todos los números es { resultadoMult }");
        }
    }
}
