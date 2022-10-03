using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo {
    public class _01_funciones {
        public void Funciones() {
            string obtenerNombre() {
                return "Fernando Nicolás";
            }

            Console.WriteLine(obtenerNombre());

            void fechaActual() {
                var msg = $"La fecha de hoy es { DateTime.Today.ToString("g") }";
                Console.WriteLine(msg);
            }

            fechaActual();

            int diaActual() {
                return DateTime.Today.Day;
            }

            Console.WriteLine($"Dia de la semana: { diaActual() }");
        }
    }
}
