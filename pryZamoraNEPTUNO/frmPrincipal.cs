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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes fp = new frmClientes();
            fp.ShowDialog();
        }

        private void consultaDeTablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTablas ft = new FrmTablas();
            ft.ShowDialog();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin Fl = new frmLogin();
            Fl.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
