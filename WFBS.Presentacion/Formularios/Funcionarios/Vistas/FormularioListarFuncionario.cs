using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBS.Presentacion.Formularios.Funcionarios.Vistas
{
    public partial class FormularioListarFuncionario : Form
    {
        public FormularioListarFuncionario()
        {
            InitializeComponent();
            WSReference.MainWSClient WS = new WSReference.MainWSClient();
            WSReference.clListarJefeFuncionario listar = new WSReference.clListarJefeFuncionario();
            dataGridView1.DataSource =  WS.Listar_Jefe_Funcionarios_desktop();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
