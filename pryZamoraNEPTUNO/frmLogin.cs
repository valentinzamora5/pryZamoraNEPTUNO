﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                frmPrincipal Fp = new frmPrincipal();
                this.Hide();
                Fp.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña ingresados son incorrectos", "Usuario/Contraseña Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
