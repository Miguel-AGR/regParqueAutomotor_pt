using regParqueadero_pt.model.entity;
using regParqueadero_pt.model.repository;
using regParqueadero_pt.util;
using regParqueadero_pt.util.validaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Nombre: AppCtrl.
 * Tipo: Controlador.
 * Funcion: Procesar las entradas del usuario y retornar las salidas relacionadas con la interacción de la clase AppView.
 *          Controla las entradas del usuario para posteriormente ejecutar metodos de clases y/o objetos para mostrar un resultado.
 * Otros: Utiliza metodos de las clases Validaciones y MensajesError para el procesamiento de entradas y manejo de excepciones.
 *          Utiliza metodos y objetos de Windows Forms para mostrar la información resultante.
*/

namespace regParqueadero_pt.controller {
    internal static class AppCtrl {

        /* Resumen: Permite limpiar los valores de las filas de un objeto DataGridView.
         * Parametros: Objeto DataGridView al que se le eliminaran las filas.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un objeto DataGridView.
        */
        public static void LimpiarLista(DataGridView dgView) {
            if (dgView == null) {
                return;
            }

            dgView.Rows.Clear();
        }

        /* Resumen: Permite reemplazar los datos existentes por nuevas filas a un objeto DataGridView mediante una lista de objetos.
         * Parametros:
         *  - dgView: Objeto de tipo DataGridView al cual se le agregaran las filas de datos.
         *  - automovilList: Objetos de tipo Automovil almacenados en un objeto List.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un objeto DataGridView y/o List<Automovil>.
        */
        public static void MostrarDatos(DataGridView dgView, List<Automovil> automovilList) {
            AppCtrl.LimpiarLista(dgView);

            if (automovilList.Count() > 0) {
                foreach (var automovil in automovilList) {
                    DataGridViewRow dgRow = new DataGridViewRow();

                    dgRow.CreateCells(dgView);

                    dgRow.Cells[0].Value = automovil.GetMarca();
                    dgRow.Cells[1].Value = automovil.GetModelo();
                    dgRow.Cells[2].Value = automovil.GetFechaIngreso();

                    dgView.Rows.Add(dgRow);
                }
            }
            else {
                string msg = "No se enconto información para mostrar.";

                MensajesInformacion.NoDataFound(msg);
            }
        }

        /* Resumen: Permite asignar nuevas filas a partir de una consulta en la base de datos generada por el metodo Automovil.GetAll().
         * Parametros:
         *  - dgView: Objeto DataGridView al cual asignar los valores.
         *  - btnActualizar: Objeto Button al cual le será asignado un nuevo texto para mostrar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un objeto DataGridView y/o Button.
        */
        public static void ListarAutomoviles(DataGridView dgView, Button btnActualizar) {
            List<Automovil> automovilList = new AutomovilDao().GetAll();
            AppCtrl.MostrarDatos(dgView, automovilList);

            if (btnActualizar != null) {
                btnActualizar.Text = "Actualizar";
            } else {
                btnActualizar = new Button();
                btnActualizar.Text = "Actualizar";
            }
        }

        /* Resumen: Permite asignar nuevas filas a partir de una consulta en la base de datos generada por el metodo Automovil.BuscarPorFechas(DateTime fechaInicio, DateTime fechaFin).
         * Parametros:
         *  - dgView: Objeto DataGridView al cual asignar los valores.
         *  - btnActualizar: Objeto Button al cual le será asignado un nuevo texto para mostrar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un objeto DataGridView y/o Button.
        */
        public static void ListarAutomovilesPorFecha(DataGridView dgView, DateTime fechaInicio, DateTime fechaFin, Button btnActualizar) {
            int val = Validaciones.CompararFechas(fechaInicio, fechaFin);

            if (val <= 0) {
                List<Automovil> automovilList = new AutomovilDao().BuscarPorFechas(fechaInicio, fechaFin);
                AppCtrl.MostrarDatos(dgView, automovilList);
                btnActualizar.Text = "Reiniciar Filtro";
            } else if (val == 1) {
                string msg = "La fecha de inicio no puede ser mayor a la fecha fin: \n" +
                    "* Fecha Inicio: " + fechaInicio.ToString() + "\n" +
                    "* Fecha Fin: " + fechaFin.ToString();

                MensajesInformacion.GenericMsg(msg);
            } else {
                string msg = "No fue posible encontrar resultados para el rango de fechas seleccionado.";
                string error = "Error de comprobación de fechas";
                
                MensajesError.AppCtrlError(msg, error);
            }
        }

        /* Resumen: Permite reiniciar los valores de objetos TextBox.Text y DateTimePicker pasados por parametro.
         * Parametros:
         *  - txtMarca: Objeto TextBox al cual reiniciar su valor de TextBox.Text.
         *  - txtModelo: Objeto TextBox al cual reiniciar su valor de TextBox.Text.
         *  - dtpFechaIngreso: Objeto DateTimePicker al cual le será asignada la fecha actual del sistema en su valor DateTimePicker.Value.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un objeto TextBox y/o DateTimePicker o al no estar inicializados (nulos).
        */
        public static void LimpiarCampos(TextBox txtMarca, TextBox txtModelo, DateTimePicker dtpFechaIngreso) {
            try {
                txtMarca.Text = "";
                txtModelo.Text = "";
                dtpFechaIngreso.Value = DateTime.Now;
            } catch (Exception ex) {
                MensajesError.AppCtrlError("Error al reiniciar los campos de entrada: ", ex.Message);
            }
        }

        /* Resumen: Permite registrar nuevos automoviles en la base de datos a partir de información ingresada por el usuario y mediante el metodo AutomovilDao.AddItem(Automovil automovil).
         * Parametros:
         *  - dgView: Objeto DataGridView al cual actualizar los valores.
         *  - txtMarca: Objeto TextBox al cual reiniciar su valor de TextBox.Text.
         *  - txtModelo: Objeto TextBox al cual reiniciar su valor de TextBox.Text.
         *  - dtpFechaIngreso: Objeto DateTimePicker al cual le será asignada la fecha actual del sistema en su valor DateTimePicker.Value.
         *  - btnActualizar: Objeto Button al cual le será asignado un nuevo texto para mostrar.
         * Exepciones: Puede generar una exepción por tipo de dato incorrecto al no recibir un objeto DataGridView, TextBox, DateTimePicker y/o Button.
        */
        public static void AgregarAutomovil(DataGridView dgView, TextBox txtMarca, TextBox txtModelo, DateTimePicker dtpFechaIngreso, Button btnActualizar) {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            DateTime fechaIngreso = dtpFechaIngreso.Value;

            string msg = "Marca: " + marca + "\nModelo: " + modelo + "\nFecha Ingreso: " + fechaIngreso;

            if ((Validaciones.ValidarLength(marca, 1, 50)) && (Validaciones.ValidarLength(modelo, 1, 100)) && (Validaciones.ValidarFechaActual(fechaIngreso))) {
                try {
                    Automovil automovil = new Automovil();

                    automovil.SetId(0);
                    automovil.SetMarca(marca);
                    automovil.SetModelo(modelo);
                    automovil.SetFechaIngreso(fechaIngreso);

                    if (new AutomovilDao().AddItem(automovil)) {
                        MensajesConfirmacion.AddItemCtrlConfir("Elemento agregado: \n" + msg, "Automovil");

                        AppCtrl.LimpiarCampos(txtMarca, txtModelo, dtpFechaIngreso);

                        AppCtrl.ListarAutomoviles(dgView, btnActualizar);
                    } else {
                        MensajesError.AddItemCtrlError(msg, "Automovil");
                        MensajesInformacion.AddItemAutomovil();
                    }
                } catch (Exception ex) {
                    MensajesError.AppCtrlError("Error al agregar el elemento.", ex.Message);
                }
            } else {
                MensajesError.AddItemCtrlError(msg, "Automovil");
                MensajesInformacion.AddItemAutomovil();
            }
        }
    }
}
