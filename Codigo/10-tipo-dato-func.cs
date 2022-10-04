using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _10_tipo_dato_func {
        public void Func() {
            Func<string> retornaString;

            string obtenerFechaActual() {
                return DateTime.Now.ToString("G");
            }

            retornaString = obtenerFechaActual;
            var result = retornaString();
            Console.WriteLine(result);

            void procesar(Func<string> productoValor) {
                Console.WriteLine("Línea anterior");
                var valor = productoValor();

                Console.WriteLine($"El valor es: { valor } ");
                Console.WriteLine("Línea posterior");
            }

            procesar(retornaString);

            Func<int, string> recibeParametros;

            string obtenerNombreMes(int mes) {
                var fecha = new DateTime(2022, mes, 1);

                return fecha.ToString("MMMM");
            }

            recibeParametros = obtenerNombreMes;
            var mesActual = recibeParametros(10);
            Console.WriteLine($"Mes actual: { mesActual }");
        }
    }
}
