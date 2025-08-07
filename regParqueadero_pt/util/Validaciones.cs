using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Nombre: Validaciones.
 * Tipo: Clase utilitaria.
 * Funcion: Realizar validaciones del sistema.
 * Otros: Implementa la interfaz IDAO, permitiendo estandarizar las consultas mediante el uso de objetos.
*/

namespace regParqueadero_pt.util.validaciones {
    internal static class Validaciones {

        /* Resumen: Evalua si una cadena puede ser un entero.
         * Retorna:
         *  - True: En caso de evaluar el string como entero.
         *  - False: En caso de evaluar el string como no entero.
         * Parametros:
         *  - val: Valor de tipo string a evaluar.
         * Exepciones: Puede generar una exepción al recibir un valor diferente al esperado (string).
        */
        public static bool ValidarInt(string val) {
            int num = 0;
            return int.TryParse(val, out num);
        }

        /* Resumen: Evalua si una cadena no es nula y cumple con una longitud minima y maxima.
         * Retorna:
         *  - True: En caso de que el string cumpla con las condiciones de longitud.
         *  - False: En caso de que el string no cumpla con las condiciones de longitud o la longitud no sea válida.
         * Parametros:
         *  - str: String a evaluar.
         *  - min: Longitud minima que se debe cumplir.
         *  - max: Longitud máxima que se debe cumplir.
         * Exepciones: Puede generar una exepción al recibir un valor diferente al esperado (string, int).
        */
        public static bool ValidarLength(string str, int min, int max) {
            bool val = false;
            
            if (min >= 0) {
                if ((min <= max) && (max != 0)) {
                    if (!string.IsNullOrWhiteSpace(str)) {
                        if ((!(str.Length < min)) || (!(str.Length > max))) {
                            val = true;
                        }
                    }
                }
            }

            return val;
        }

        /* Resumen: Evalua si una instancia DateTime no es nula y es menor o igual a la fecha actual.
         * Retorna:
         *  - True: En caso de que el objeto sea menor o igual a la fecha actual.
         *  - False: En caso de que el objeto sea nulo o mayor a la fecha actual.
         * Parametros:
         *  - fecha: Instancia DateTime a evaluar.
         * Exepciones: Puede generar una exepción al recibir un valor diferente al esperado (DateTime).
        */
        public static bool ValidarFechaActual(DateTime fecha) {
            bool val = false;
            DateTime fechaActual = DateTime.Now;

            if (fecha != null) {
                if (fechaActual >= fecha) {
                    val = true;
                }
            }

            return val;
        }

        /* Resumen: Evalua si una instancia DateTime es nula, menor, igual o mayor a otra instancia DateTime.
         * Retorna:
         *  - 1: En caso de que el objeto fecha1 sea mayor al objeto fecha2.
         *  - -1: En caso de que el objeto fecha1 sea menor al objeto fecha2.
         *  - 0: En caso de que el objeto fecha1 sea igual al objeto fecha2.
         *  - 2: En caso de que el objeto fecha1 y/o el objeto fecha2 sea nulo.
         * Parametros:
         *  - fecha1: Instancia DateTime a comparar.
         *  - fecha2: Instancia DateTime a comparar.
         * Exepciones: Puede generar una exepción al recibir un valor diferente al esperado (DateTime).
        */
        public static int CompararFechas(DateTime fecha1, DateTime fecha2) {
            if ((fecha1 != null) && (fecha1 != null)) {
                if (fecha1 > fecha2) {
                    return 1;
                } else if (fecha1 < fecha2) {
                    return -1;
                } else {
                    return 0;
                }
            } else {
                return 2;
            }
        }
    }
}
