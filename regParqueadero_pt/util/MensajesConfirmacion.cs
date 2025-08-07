using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Nombre: MensajesConfirmacion.
 * Tipo: Clase utilitaria.
 * Funcion: Centralizar los mensajes de confirmación de la aplicación.
 * Otros: Muestra retroalimentación de confirmación al usuario utilizando la clase MessageBox.
*/

namespace regParqueadero_pt.util {
    internal static class MensajesConfirmacion {

        /* Resumen: Muestra un mensaje de confirmación generico.
         * Parametros:
         *  - msg: String con el mensaje a mostrar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto o nulo.
        */
        public static void GenericMsg(string msg) {
            string infoTitle = "Confirmación";
            MessageBox.Show(msg, infoTitle);
        }

        /* Resumen: Muestra un mensaje de confirmación generico con titulo correspondiente a la acción Agregar elementos.
         * Parametros:
         *  - confirmMsg: String con el mensaje a mostrar.
         *  - tipo: String que indica el tipo de elemnto agregado.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto o nulo.
        */
        public static void AddItemCtrlConfir(string confirmMsg, string tipo) {
            string confirmTitle = "Agregar " + tipo;
            MessageBox.Show(confirmMsg, confirmTitle);
        }
    }
}
