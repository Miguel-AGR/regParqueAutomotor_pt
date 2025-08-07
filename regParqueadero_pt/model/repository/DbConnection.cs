using regParqueadero_pt.util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Nombre: DbConnection.
 * Tipo: Clase dedicada a la conexión con base de datos SQL.
 * Funcion: Permite establecer una conexión con SQL Server para que otras clases u objetos puedan ejecutar consultas SQL sobre la base de datos db_ParqueAutomotor.
 * Otros: Establece una conexión en la maquina local.
*/

namespace regParqueadero_pt {
    internal class DbConnection {
        //  - connectionStr: String que almacenará la información para una conexión con una base de datos en SQL Server.
        private string connectionStr;

        //  - connection: Instancia de la clase SqlConnection que permite establecer una conexión con una base de datos en SLQ Server.
        private SqlConnection connection;

        /* Resumen: Metodo constructor vacio.
         * Retorna: Nuevo objeto de tipo DbConnection con atributos inicializados.
         * Exepciones:
         *  - Error de conexión SQL.
         *  - Base de datos no disponible.
         *  - Servidor no disponible.
         *  - Error de autenticación con el servidor.
        */
        public DbConnection() {
            this.SetConnectionStr();
            this.SetConnection();
        }

        /* Resumen: Asigna el string de conexión al atributo DbConnection.connectionStr para la base de datos en SQL Server.
        */
        private void SetConnectionStr() {
            this.connectionStr = "Server=localhost\\SQLEXPRESS;Database=db_ParqueAutomotor;Integrated Security=true;";
        }

        /* Resumen: Inicializa el atributo DbConnection.connection mediante el metodo constructor de SqlConnection(string connectionString) para una base de datos en SQL Server.
         * Exepciones:
         *  - Error de conexión SQL.
         *  - Base de datos no disponible.
         *  - Servidor no disponible.
         *  - Error de autenticación con el servidor.
        */
        private void SetConnection() {
            try {
                this.connection = new SqlConnection(this.connectionStr);
            } catch (Exception ex) {
                MensajesError.DbConnectionError("Error al establecer la conexión: \n" + ex.Message);
            }
        }

        /* Resumen: Metodo de tipo Get. Permite obtener el atributo DbConnection.connection.
         * Retorna: Una instancia de la clase SqlConnection perteneciente a un objeto DbConnection.
        */
        public SqlConnection GetConnection() {
            return this.connection;
        }

        /* Resumen: Permite abrir una conexión con una base de datos en SQL Server mediante el atributo DbConnection.connection.
         * Exepciones:
         *  - Error de conexión SQL.
         *  - Base de datos no disponible.
         *  - Servidor no disponible.
         *  - Error de autenticación con el servidor.
         *  - Error al abrir, la conexión ya se encuentra abierta.
        */
        public void OpenConnection() {
            try {
                this.connection.Open();
            } catch (Exception ex) {
                MensajesError.DbConnectionError("Error al inicializar la conexión: \n" + ex.Message);
            }
        }

        /* Resumen: Permite cerrar una conexión previamente abierta con una base de datos en SQL Server mediante el atributo DbConnection.connection.
         * Exepciones:
         *  - Error de conexión SQL.
         *  - Base de datos no disponible.
         *  - Servidor no disponible.
         *  - Error de autenticación con el servidor.
         *  - Error al cerrar, la conexión ya se encuentra cerrada.
        */
        public void CloseConnection() {
            try {
                this.connection.Close();
            } catch (Exception e) {
                MensajesError.DbConnectionError("Error al finalizar la conexión: \n" + e.Message);
            }
        }
    }
}
