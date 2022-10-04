using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _07_tuplas {
        public void tuplas() {
            var tupla = (99, 23, 12, "Fernando", true);
            Console.WriteLine(tupla);

            (int edad, bool bandera, string nombre) = (25, true, "Fer Santi");
            Console.WriteLine($"Edad: { edad } | Nombre: { nombre } | Bandera: { bandera }");
        }
    }
}
