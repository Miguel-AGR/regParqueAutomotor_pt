using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Nombre: MensajesError.
 * Tipo: Clase utilitaria.
 * Funcion: Centralizar los mensajes de errores de la aplicación.
 * Otros: Muestra información de errores utilizando la clase MessageBox.
*/

namespace regParqueadero_pt.util {
    internal static class MensajesError {

        /* Resumen: Muestra un mensaje de Error generico.
         * Parametros:
         *  - msg: String con el mensaje a mostrar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto o nulo.
        */
        public static void GenericMsg(string msg) {
            string infoTitle = "Error";
            MessageBox.Show(msg, infoTitle);
        }

        /* Resumen: Muestra un mensaje de error generico con titulo correspondiente a Error de conexión con base de datos.
         * Parametros:
         *  - errorMsg: String con el mensaje a mostrar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto o nulo.
        */
        public static void DbConnectionError(string errorMsg) {
            string errorTitle = "Error de conexión Base de Datos";
            MessageBox.Show(errorMsg, errorTitle);
        }

        /* Resumen: Muestra un mensaje de error generico con titulo correspondiente a Error en un proceso con un Data Access Object.
         * Parametros:
         *  - errorMsg: String con el mensaje a mostrar.
         *  - dao: String con el nombre de la clase origen del error.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto o nulo.
        */
        public static void DaoProcesError(string errorMsg, string dao) {
            string errorTitle = "Error de procesamiento en " + dao;
            MessageBox.Show(errorMsg, errorTitle);
        }

        /* Resumen: Muestra un mensaje de error generico con titulo correspondiente a error del aplicativo con el detallle del error con origen en la clase AppCtrl.
         * Parametros:
         *  - msg: String con el mensaje a mostrar.
         *  - error: String con el detalle del error/excepcion.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto o nulo.
        */
        public static void AppCtrlError(string msg, string error) {
            string errorTitle = "Error de la aplicación";
            MessageBox.Show(msg + "\n" + error, errorTitle);
        }

        /* Resumen: Muestra un mensaje de error generico con titulo correspondiente a error del aplicativo al agregar un elemento con origen en la clase AppCtrl.
         * Parametros:
         *  - errorMsg: String con el mensaje a mostrar.
         *  - tipo: String con el nombre del elemento a agregar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto o nulo.
        */
        public static void AddItemCtrlError(string errorMsg, string tipo) {
            string errorTitle = "Error al agregar " + tipo;
            MessageBox.Show(errorMsg, errorTitle);
        }
    }
}
