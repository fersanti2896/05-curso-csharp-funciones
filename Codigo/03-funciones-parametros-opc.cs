using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo { 
    public class _03_funciones_parametros_opc {
        public void funcionesParametrosOpcionales() {
            void imprimeConsola(string msg, bool mayus = true) {
                if (mayus) {
                    msg = msg.ToUpper();
                }

                Console.WriteLine(msg);
            }

            imprimeConsola("Fernando quiere a Mar");
        }
    }
}
