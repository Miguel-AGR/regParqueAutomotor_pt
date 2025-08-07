using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Nombre: Program.
 * Tipo: Clase Principal.
 * Funcion: Mediante el metodo Main inicia la ejecución del sistema.
 * Otros: Ejecuta inicalmente la interfaz gráfica del sistema.
*/

namespace regParqueadero_pt {
    internal static class Program {
        [STAThread]
        
        /* Resumen: Metodo de tipo Main. Encargado de las instrucciones de inicialización de la aplicación. Inicia la interfaz gráfica de usuario.
        */
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppView());
        }
    }
}
