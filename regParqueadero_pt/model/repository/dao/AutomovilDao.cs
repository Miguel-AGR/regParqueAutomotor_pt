using regParqueadero_pt.model.entity;
using regParqueadero_pt.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

/*
 * Nombre: AutomovilDao.
 * Tipo: Data Access Object.
 * Funcion: Ejecutar consultas SQL relacionadas con la tabla tbl_Automovil.
 * Otros: Implementa la interfaz IDAO, permitiendo estandarizar las consultas mediante el uso de objetos.
*/

namespace regParqueadero_pt.model.repository {
    internal class AutomovilDao : IDAO<Automovil> {
        //  - daoName: Permite identificar la clase DataAccessObject para ser utilizado para mostrar información al usuario.
        private readonly string daoName = "Automovil DAO";

        /* Resumen: Metodo constructor vacio.
         * Retorna: Nuevo objeto de tipo AutomovilDao con atributos en null.
        */
        public AutomovilDao() {
        }

        /* Resumen: Metodo de tipo Get. Permite obtener el nombre de la clase.
         * Retorna: Valor string con el nombre de la clase.
        */
        public string GetDaoName() {
            return daoName;
        }

        /* Resumen: Permite obtener todos datos de la tabla tbl_Automovil mediante una consulta SQL y retornarlos en forma de lista de objetos (List<Automovil>).
         * Retorna: Un objeto de tipo List con los resultados de la consulta como instancias de la clase Automovil.
         */
        public List<Automovil> GetAll() {
            List<Automovil> listAutomovil = new List<Automovil>();
            DbConnection dbConnection = new DbConnection();

            try {
                using (SqlConnection conn = dbConnection.GetConnection()) {
                    conn.Open();

                    string query = @"SELECT Id_Automovil, MarcaAutomovil, ModeloAutomovil, FechaIngreso
                        FROM tbl_Automovil
                        ORDER BY FechaIngreso DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader result = cmd.ExecuteReader();

                    while (result.Read()) {
                        Automovil automovil = new Automovil(
                            (int)result.GetInt32(result.GetOrdinal("Id_Automovil")),
                            result.GetString(result.GetOrdinal("MarcaAutomovil")),
                            result.GetString(result.GetOrdinal("ModeloAutomovil")),
                            result.GetDateTime(result.GetOrdinal("FechaIngreso"))
                        );

                        listAutomovil.Add(automovil);
                    }
                }
            } catch (Exception ex) {
                MensajesError.DaoProcesError("Error: \n" + ex.Message, this.GetDaoName());
            } finally {
                if (dbConnection != null) {
                    dbConnection.CloseConnection();
                    dbConnection = null;
                }
            }

            return listAutomovil;
        }

        /* Resumen: Permite agregar datos a la tabla tbl_Automovil mediante una consulta SQL.
         * Retorna:
         *  - True: En caso de que la consulta sea exitosa.
         *  - Falae: En caso de que la consulta falle.
         * Parametros:
         *  - automovil: Objeto de la clase Automovil con la información a almacenar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un objeto Automovil.
         */
        public bool AddItem(Automovil automovil) {
            if (automovil != null) {
                DbConnection dbConnection = new DbConnection();
            
                try {
                    using (SqlConnection conn = dbConnection.GetConnection()) {
                        conn.Open();

                        string query = @"INSERT INTO tbl_Automovil (MarcaAutomovil, ModeloAutomovil, FechaIngreso)
                            VALUES (@Marca, @Modelo, @Fecha)";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@Marca", automovil.GetMarca());
                        cmd.Parameters.AddWithValue("@Modelo", automovil.GetModelo());
                        cmd.Parameters.AddWithValue("@Fecha", automovil.GetFechaIngreso().Date);

                        cmd.ExecuteNonQuery();
                    
                        return true;
                    }
                } catch (Exception ex) {
                    MensajesError.DaoProcesError("Error: \n" + ex.Message, this.GetDaoName());
                    return false;
                } finally {
                    if (dbConnection != null) {
                        dbConnection.CloseConnection();
                        dbConnection = null;
                    }
                }
            } else {
                return false;
            }
        }

        /* Resumen: Permite obtener datos de la tabla tbl_Automovil mediante una consulta SQL filtrando por un rango de fechas (inicio y fin) y retornarlos en forma de lista de objetos (List<Automovil>).
         * Retorna: Un objeto de tipo List con los resultados de la consulta como instancias de la clase Automovil.
         * Parametros:
         *  - fechaInicio: Objeto de la clase DateTime la cual establece la fecha de inicio a consultar.
         *  - fechaInicio: Objeto de la clase DateTime la cual establece la fecha de fin a consultar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un objeto DateTime.
         */
        public List<Automovil> BuscarPorFechas(DateTime fechaInicio, DateTime fechaFin) {
            List<Automovil> listAutomovil = new List<Automovil>();
            DbConnection dbConnection = new DbConnection();

            try {
                using (SqlConnection conn = dbConnection.GetConnection()) {
                    conn.Open();

                    string query = @"SELECT Id_Automovil, MarcaAutomovil, ModeloAutomovil, FechaIngreso
                        FROM tbl_Automovil
                        WHERE FechaIngreso BETWEEN @FechaInicio AND @FechaFin
                        ORDER BY FechaIngreso DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Date.AddDays(1).AddSeconds(-1));

                    SqlDataReader result = cmd.ExecuteReader();

                    while (result.Read()) {
                        Automovil automovil = new Automovil(
                            (int)result.GetInt32(result.GetOrdinal("Id_Automovil")),
                            result.GetString(result.GetOrdinal("MarcaAutomovil")),
                            result.GetString(result.GetOrdinal("ModeloAutomovil")),
                            result.GetDateTime(result.GetOrdinal("FechaIngreso"))
                        );

                        listAutomovil.Add(automovil);
                    }
                }
            } catch (Exception ex) {
                MensajesError.DaoProcesError("Error: \n" + ex.Message, this.GetDaoName());
            } finally {
                if (dbConnection != null) {
                    dbConnection.CloseConnection();
                    dbConnection = null;
                }
            }

            return listAutomovil;
        }
    }
}
