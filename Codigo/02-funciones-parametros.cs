using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _02_funciones_parametros {
        public void funcionesParametros() {
            int Duplicar(int valor) {
                return valor * 2;
            }

            int num1 = Duplicar(2);
            Console.WriteLine($"Value: { num1 }");

            int num2 = Duplicar(54);
            Console.WriteLine($"Value: { num2 }");

            int Sumar(int num, int num2) {
                return num + num2;
            }

            int val1 = Sumar(18, 2);
            Console.WriteLine($"Value: { val1 }");

            int val2 = Sumar(18, 31);
            Console.WriteLine($"Value: { val2 }");

            void repeticionConsola(string msg, int repeticiones) {
                for (int i = 0; i < repeticiones; i++) {
                    Console.WriteLine(msg);
                }
            }

            repeticionConsola("Fernando quiere a Mar", 10);
        }
    }
}
