using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
     public class _05_tipos_referencia {
        public void funcionesTiposReferencia() {
            int cantidad = 5;

            void duplicar(ref int n) {
                n *= 2;
                Console.WriteLine($"El valor dentro de la función es: { n }");
            }

            Console.WriteLine($"El valor fuera de la función es: { cantidad }");
            duplicar(ref cantidad);
            Console.WriteLine($"El valor fuera de la función es: { cantidad }");

            var valores = new int[] { 1, 2, 3 };

            void duplicarArreglo(int[] numeros) {
                for (int i = 0; i < numeros.Length; i++) {
                    numeros[i] *= 2;
                }
            }

            void imprimirArreglo(int[] numeros) {
                foreach (var num in numeros) {
                    Console.Write($"{ num } ");
                }
            }

            Console.WriteLine($"\nValores del arreglo antes del duplicado:");
            imprimirArreglo(valores);

            duplicarArreglo(valores);

            Console.WriteLine($"\nValores del arreglo después del duplicado:");
            imprimirArreglo(valores);

            var name = "Fer Santi";

            void nameMayus(string name) {
                name = name.ToUpper();
                Console.WriteLine($"El valor dentro de la función es: { name }");
            }

            Console.WriteLine($"\nEl valor fuera de la función es: { name }");
            nameMayus(name);
            Console.WriteLine($"El valor fuera de la función es: { name }");
        }
    }
}
