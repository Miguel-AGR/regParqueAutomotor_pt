using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 * Nombre: Automovil.
 * Tipo: Entidad.
 * Funcion: Definir los atributos y metodos para el manejo de los datos en la tabla tbl_Automovil.
 * Otros: Facilita la interacción con los datos almacenados mediante el uso de objetos.
 *      Su estructura esta definida según las columnas de la tabla tbl_Automovil en la base de datos.
*/

namespace regParqueadero_pt.model.entity {
    internal class Automovil {
        //  - id: Identificador de tipo entero.
        private int id;

        //  - marca: Marca del automovil de tipo string.
        private string marca;
        
        //  - modelo: Modelo del automovil de tipo string.
        private string modelo;
        
        //  - fechaIngreso: Fecha de ingreso del automovil de tipo DateTime.
        private DateTime fechaIngreso;


        /* Resumen: Metodo constructor vacio.
         * Retorna: Nuevo objeto de tipo Automovil con atributos en null.
        */
        public Automovil() {
        }

        /* Resumen: Metodo constructor con parametros.
         * Retorna: Nuevo objeto de tipo Automovil con atributos definidos.
         * Parametros: 
         *  - id: Identificador de tipo entero.
         *  - marca: Marca del automovil de tipo string (cadena).
         *  - modelo: Modelo del automovil de tipo string.
         *  - fechaIngreso: Fecha de ingreso del automovil de tipo DateTime (fecha-hora).
        */
        public Automovil(int id, string marca, string modelo, DateTime fechaIngreso) {
            this.SetId(id);
            this.SetMarca(marca);
            this.SetModelo(modelo);
            this.SetFechaIngreso(fechaIngreso);
        }

        /* Resumen: Metodo de tipo Get. Permite obtener el valor del Id del objeto.
         * Retorna: Valor entero que representa al Identificador del objeto.
        */
        public int GetId() { return this.id; }

        /* Resumen: Metodo de tipo Set. Permite asignar un valor como Id del objeto.
         * Parametros: Número entero que representara el identificador del objeto.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un valor entero.
        */
        public void SetId(int id) { this.id = id; }

        /* Resumen: Metodo de tipo Get. Permite obtener el valor de la Marca del objeto.
         * Retorna: Valor string que representa la Marca del objeto.
        */
        public string GetMarca() { return this.marca; }

        /* Resumen: Metodo de tipo Set. Permite asignar el valor de la Marca del objeto.
         * Parametros: String que representara la Marca del objeto.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un valor string.
        */
        public void SetMarca(string marca) { this.marca = marca; }

        /* Resumen: Metodo de tipo Get. Permite obtener el valor del Modelo del objeto.
         * Retorna: Valor string que representa el Modelo del objeto.
        */
        public string GetModelo() { return this.modelo; }

        /* Resumen: Metodo de tipo Set. Permite asignar el valor del Modelo del objeto.
         * Parametros: String que representara el Modelo del objeto.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un valor string.
        */
        public void SetModelo(string modelo) { this.modelo = modelo; }

        /* Resumen: Metodo de tipo Get. Permite obtener el valor de la Fecha de Ingreso del objeto.
         * Retorna: Valor DateTime que representa la Fecha de Ingreso del objeto.
        */
        public DateTime GetFechaIngreso() { return this.fechaIngreso; }

        /* Resumen: Metodo de tipo Set. Permite asignar el valor de la Fecha de Ingreso del objeto.
         * Parametros: Objeto de tipo DateTime que representara la Fecha de Ingreso del objeto.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un valor DateTime.
        */
        public void SetFechaIngreso (DateTime fechaIngreso) { this.fechaIngreso = fechaIngreso; }
    }
}
