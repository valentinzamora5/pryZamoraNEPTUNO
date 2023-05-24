using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryZamoraNEPTUNO
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.ListarClientes(dgvClientes, "NEPTUNO", "Clientes");


        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.CargarPaisCiudad(cmbCiudad, cmbPais, "NEPTUNO", "Clientes");

        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.ListarCiudad(dgvClientes, "NEPTUNO", "Clientes", cmbCiudad, cmbPais);
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.ListarPais(dgvClientes, "NEPTUNO", "Clientes", cmbPais, cmbCiudad);
        }
    }
}
