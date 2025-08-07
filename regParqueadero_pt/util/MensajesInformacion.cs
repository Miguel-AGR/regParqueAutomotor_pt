using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Nombre: MensajesInformacion.
 * Tipo: Clase utilitaria.
 * Funcion: Centralizar los mensajes informativos de la aplicación.
 * Otros: Muestra mensajes de tipo informativos utilizando la clase MessageBox.
*/

namespace regParqueadero_pt.util {
    internal static class MensajesInformacion {

        /* Resumen: Muestra un mensaje informativo generico.
         * Parametros:
         *  - msg: String con el mensaje a mostrar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto o nulo.
        */
        public static void GenericMsg(string msg) {
            string infoTitle = "Información";
            MessageBox.Show(msg, infoTitle);
        }

        /* Resumen: Muestra un mensaje informativo generico con titulo correspondiente al proceso de agregar un elemento Automovil.
        */
        public static void AddItemAutomovil() {
            string infoTitle = "Agregar Automovil";
            string infoMsg = "Para agregar un automovil debe tener en cuenta: \n" +
                "* No se permiten campos vacios. \n" +
                "* Marca: La longitud permitida de caracteres es de min 1 y máx 50. \n" +
                "* Modelo: La longitud permitida de caracteres es de min 1 y máx 100. \n" +
                "* Fecha Ingreso: Debe ser igual o menor al día actual.";
            MessageBox.Show(infoMsg, infoTitle);
        }

        /* Resumen: Muestra un mensaje informativo generico con el proposito de notificar la ausencia de resultados de una consulta.
         * Parametros:
         *  - infoMsg: String con el mensaje a mostrar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto o nulo.
        */
        public static void NoDataFound(string infoMsg) {
            string infoTitle = "Información";
            MessageBox.Show(infoMsg, infoTitle);
        }
    }
}
