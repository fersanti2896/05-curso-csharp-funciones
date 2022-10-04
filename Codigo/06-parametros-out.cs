using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _06_parametros_out {
        public void parametrosOut() {
            int cantidad;

            void duplicar(int operando, out int n) {
                operando *= 2;
                n = operando;
                Console.WriteLine($"El valor dentro de la función es: { n }");
            }

            duplicar(3, out cantidad);
            Console.WriteLine($"El valor fuera de la función es: { cantidad }");

            void duplicarAndTriplicar(int num, out int resultDuplicado, out int resultTriplicado) {
                resultDuplicado = num * 2;
                resultTriplicado = num * 3;
            }

            int resultDuplicado, resultTriplicado;
            duplicarAndTriplicar(3, out resultDuplicado, out resultTriplicado);

            Console.WriteLine($"El doble es: { resultDuplicado }");
            Console.WriteLine($"El triple es: { resultTriplicado }");
        }
    }
}
