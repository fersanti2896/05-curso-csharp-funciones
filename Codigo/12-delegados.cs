using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _12_delegados {
        public void delegados() {
            Action action;
            Func<int> func;
            Predicate<int> predicado;

            bool modificacion(string valor, out int resultado) {
                return int.TryParse(valor, out resultado);
            }

            /* modificacionDelegado valor = modificacion;

            int cantidad;

            if (valor("12", out cantidad)) {
                Console.WriteLine($"Valor: { cantidad }");
            }

            //delegate bool modificacionDelegado(string valor, out int resultado); */
        }
    }
}
