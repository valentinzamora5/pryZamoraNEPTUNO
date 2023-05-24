using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZamoraNEPTUNO
{
    public partial class FrmTablas : Form
    {

        public string cadenaConexion;
        public FrmTablas()
        {
            InitializeComponent();
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {

            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            cadenaConexion = clsBaseDeDatos.ListarTablas(cmbTablas, dgvTablas, txtBaseDatos);
            if (cadenaConexion != "")
            {
                lblBaseDatos.Enabled = true;
                lblTabla.Enabled = true;
                cmbTablas.Enabled = true;
            }


        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.MostrarTablas(cmbTablas, cadenaConexion, dgvTablas);
        }

        private void FrmTablas_Load(object sender, EventArgs e)
        {

        }
    }
}
