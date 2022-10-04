using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _13_funciones_anonimas {
        public void funcionesAnonimas() {
            Action imprimeMensaje = () => {
                Console.WriteLine(DateTime.Now.ToString());
            };

            imprimeMensaje();

            void procesar(Action accion) {
                Console.WriteLine("Antes de ejecutar la acción");
                accion();
                Console.WriteLine("Después de ejecutar la acción");
            }

            procesar(() => {
                Console.WriteLine(DateTime.Now.ToString());
            });

            /* Función anónima que recibe un parámetro y retorna un valor */
            Func<int, int> duplicar = a => 2 * a;

            /* Función anonima que recibe 2 parámetros y retorna un valor */
            Func<bool, string, int> ejemplo = (boleano, cadena) => {
                return 42;
            };
        }
    }
}
