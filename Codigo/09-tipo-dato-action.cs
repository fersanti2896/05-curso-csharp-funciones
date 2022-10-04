using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _09_tipo_dato_action {
        public void Action() {
            Action imprimeMensaje;

            void imprimirFechaAct() {
                Console.WriteLine(DateTime.Now.ToString());
            }

            void imprimeNombre() {
                Console.WriteLine("Fernando Nicolás");
            }

            imprimeMensaje = imprimeNombre;
            imprimeMensaje();

            imprimeMensaje = imprimirFechaAct;
            imprimeMensaje();

            Console.WriteLine();

            void procesar(Action action) {
                Console.WriteLine("Antes de ejecutar el action");
                action();
                Console.WriteLine("Después de ejecutar el action");
            }

            procesar(imprimirFechaAct);
            Console.WriteLine();
            procesar(imprimeNombre);

            Action<string, int> imprimeNVeces;

            void imprimeMsg(string msg, int num) {
                for (int i = 0; i < num; i++) {
                    Console.WriteLine(msg);
                }
            }

            imprimeMsg("Fernando", 10);
            imprimeNVeces = imprimeMsg;
        }
    }
}
