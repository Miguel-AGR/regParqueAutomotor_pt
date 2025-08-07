using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Nombre: IDAO.
 * Tipo: Interfaz.
 * Funcion: Estandarizar los metodos para ejecutar consultas SQL desde los objetos de tipo Data Access Object.
 * Otros: Su implementación fuerza a una clase a trabajar únicamente con un tipo de objeto (representado por <E>).
*/

namespace regParqueadero_pt.model.repository {
    internal interface IDAO <E> {

        /* Resumen: Metodo de tipo Get. Permite obtener el nombre de la clase que implementa la interfaz.
         * Retorna: Valor string con el nombre de la clase que implementa la interfaz.
        */
        string GetDaoName();

        /* Resumen: Metodo de tipo Get. Permite obtener todos los datos de una tabla y los retorna en un objeto List que contiene instancias de una clase (<E>) definida.
         * Retorna: Un objeto de tipo List con los resultados de la consulta SQL como instancias de una clase definida (<E>).
        */
        List<E> GetAll();

        /* Resumen: Permite agregar datos a una tabla a partir de una instancia de una clase (<E>).
         * Retorna:
         *  - True: En caso de que la consulta sea exitosa.
         *  - Falae: En caso de que la consulta falle.
         * Parametros:
         *  - e: Objeto de una clase definida (<E>) con la información a almacenar.
         * Exepciones: Puede generar una exepción al recibir un objeto diferente al esperado (<E>).
        */
        bool AddItem(E e);
    }
}
