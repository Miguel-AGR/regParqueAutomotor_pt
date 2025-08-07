using regParqueadero_pt.controller;
using regParqueadero_pt.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Nombre: AppView : Form.
 * Tipo: Clase parcial de una interfaz grafica.
 * Funcion: Ejecutar funciones de acuerdo con las interacciones del usuario.
 * Otros: Utiliza la clase AppCtrl para la ejecución de acciones.
*/

namespace regParqueadero_pt {
    public partial class AppView : Form {

        /* Resumen: Constructor sin parametros que inicializa los componentes de la interfaz gráfica.
         * Retorna: Una instancia de una interfaz grafica de usuario de tipo AppView.
        */
        public AppView() {
            InitializeComponent();
        }

        /* Resumen: Permite mostrar todos los datos de la tabla tbl_Automovil al inicializar la interfaz gráfica.
         * Exepciones: Error de consulta o conexión SQL, se mostrará un mensaje (MessageBox) con el detalle correspondiente.
        */
        private void Form1_Load(object sender, EventArgs e) {
            AppCtrl.LimpiarCampos(this.txtMarca, this.txtModelo, this.dtpFechaIngreso);
            AppCtrl.ListarAutomoviles(this.automovilesDGV, this.btnActualizar);
        }

        /* Resumen: Permite actualizar los datos mostrados al ejecutar la consulta mediante el metodo AppCtrl.ListarAutomoviles(DataGridView dgView, Button btnActualizar).
         * Exepciones: Error de consulta o conexión SQL, se mostrará un mensaje (MessageBox) con el detalle correspondiente.
        */
        private void btnActualizar_Click(object sender, EventArgs e) {
            AppCtrl.ListarAutomoviles(this.automovilesDGV, this.btnActualizar);
        }

        /* Resumen: Permite filtrar los datos mostrados al ejecutar una consulta mediante el metodo AppCtrl.ListarAutomovilesPorFecha(DataGridView dgView, DateTime fechaInicio, DateTime fechaFin, Button btnActualizar).
         * Exepciones:
         *  - Error de consulta o conexión SQL.
         *  - Error de fechas no válidas o fuera de rango.
         *  Se mostrará un mensaje (MessageBox) con el detalle correspondiente.
        */
        private void btnFiltrar_Click(object sender, EventArgs e) {
            AppCtrl.ListarAutomovilesPorFecha(this.automovilesDGV, this.dtpFechaInicio.Value, this.dtpFechaFin.Value, this.btnActualizar);
        }

        /* Resumen: Permite agregar datos al ejecutar una consulta mediante el metodo AppCtrl.AgregarAutomovil(DataGridView dgView, TextBox txtMarca, TextBox txtModelo, DateTimePicker dtpFechaIngreso, Button btnActualizar).
         * Exepciones:
         *  - Error de consulta o conexión SQL.
         *  - Error de fecha de ingreso no válida o fuera de rango.
         *  - Error de valores de entrada no válidos (marca y/o modelo).
         *  Se mostrará un mensaje (MessageBox) con el detalle correspondiente.
        */
        private void btnAgregar_Click(object sender, EventArgs e) {
            AppCtrl.AgregarAutomovil(this.automovilesDGV, this.txtMarca, this.txtModelo, this.dtpFechaIngreso, this.btnActualizar);
        }

        /* Resumen: Permite reiniciar los campos de entradas mediante el metodo AppCtrl.LimpiarCampos(TextBox txtMarca, TextBox txtModelo, DateTimePicker dtpFechaIngreso).
         * Exepciones:
         *  - Error de modificación de atributos por objetos nulos (TextBox, DateTimePicker).
         *  Se mostrará un mensaje (MessageBox) con el detalle correspondiente.
        */
        private void btnLimpiar_Click(object sender, EventArgs e) {
            AppCtrl.LimpiarCampos(this.txtMarca, this.txtModelo, this.dtpFechaIngreso);
        }
    }
}