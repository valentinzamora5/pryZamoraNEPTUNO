using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace pryZamoraNEPTUNO
{
    class clsBaseDeDatos
    {
        public OleDbCommand Comando = new OleDbCommand();
        public OleDbDataReader Lector;
        public OleDbConnection Conexion = new OleDbConnection();

        public void ListarClientes(DataGridView dgvClientes, string BaseDeDatos, string Tabla)
        {
            Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            dgvClientes.Rows.Clear();
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandText = Tabla;
                Comando.CommandType = CommandType.TableDirect;
                Comando.Connection.Open();

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    dgvClientes.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                }

                Comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void CargarPaisCiudad(ComboBox cmbCiudad, ComboBox cmbPais, string BaseDeDatos, string Tabla)
        {
            Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            bool encontradoCiudad = false;
            bool encontradoPais = false;
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandText = Tabla;
                Comando.CommandType = CommandType.TableDirect;
                Comando.Connection.Open();

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    for (int i = 0; i < cmbCiudad.Items.Count; i++)
                    {
                        if (Lector[5].ToString() == cmbCiudad.Items[i].ToString())
                        {
                            encontradoCiudad = true;
                        }
                    }
                    if (encontradoCiudad == false)
                    {
                        cmbCiudad.Items.Add(Lector[5]);
                    }
                    encontradoCiudad = false;

                    for (int i = 0; i < cmbPais.Items.Count; i++)
                    {
                        if (Lector[8].ToString() == cmbPais.Items[i].ToString())
                        {
                            encontradoPais = true;
                        }
                    }
                    if (encontradoPais == false)
                    {
                        cmbPais.Items.Add(Lector[8]);
                    }
                    encontradoPais = false;
                }
                Comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void ListarPais(DataGridView dgvClientes, string BaseDeDatos, string Tabla, ComboBox cmbPais, ComboBox cmbCiudad)
        {
            if (cmbPais.SelectedIndex != -1)
            {
                Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
                dgvClientes.Rows.Clear();
                cmbCiudad.SelectedIndex = -1;
                try
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = Tabla;
                    Comando.CommandType = CommandType.TableDirect;
                    Comando.Connection.Open();

                    Lector = Comando.ExecuteReader();

                    while (Lector.Read())
                    {
                        if (Lector[8].ToString() == cmbPais.Text)
                        {
                            dgvClientes.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                        }
                    }
                    Comando.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        public void ListarCiudad(DataGridView dgvClientes, string BaseDeDatos, string Tabla, ComboBox cmbCiudad, ComboBox cmbPais)
        {
            if (cmbCiudad.SelectedIndex != -1)
            {
                Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
                dgvClientes.Rows.Clear();
                cmbPais.SelectedIndex = -1;
                try
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = Tabla;
                    Comando.CommandType = CommandType.TableDirect;
                    Comando.Connection.Open();

                    Lector = Comando.ExecuteReader();

                    while (Lector.Read())
                    {
                        if (Lector[5].ToString() == cmbCiudad.Text)
                        {
                            dgvClientes.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                        }
                    }
                    Comando.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        public string ListarTablas(ComboBox cmbTablas, DataGridView dgvTablas, TextBox txtBaseDatos)
        {
            dgvTablas.DataSource = null;
            cmbTablas.SelectedIndex = -1;
            string cadenaConexion = "";
            using (OpenFileDialog OpenFileDialog = new OpenFileDialog())
            {
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivo = OpenFileDialog.FileName;
                    txtBaseDatos.Text = Path.GetFileName(archivo);

                    if (Path.GetExtension(archivo) == ".accdb")
                    {
                        cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + archivo + ";Persist Security Info=False;";
                    }
                    else
                    {
                        cadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + archivo + ";";
                    }

                    Conexion.ConnectionString = cadenaConexion;

                    cmbTablas.Items.Clear();

                    try
                    {
                        Conexion.Open();

                        DataTable tablas = Conexion.GetSchema("Tables");

                        foreach (DataRow tabla in tablas.Rows)
                        {
                            if (tabla[3].ToString() == "TABLE")
                            {
                                cmbTablas.Items.Add(tabla[2].ToString());
                            }
                        }
                        Conexion.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            return cadenaConexion;
        }

        public void MostrarTablas(ComboBox cmbTablas, string cadenaConexion, DataGridView dgvTablas)
        {
            if (cmbTablas.SelectedIndex != -1)
            {
                Conexion.ConnectionString = cadenaConexion;

                try
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = cmbTablas.Text;
                    Comando.CommandType = CommandType.TableDirect;
                    Comando.Connection.Open();

                    Lector = Comando.ExecuteReader();

                    DataTable tabla = new DataTable();
                    tabla.Load(Lector);

                    dgvTablas.DataSource = tabla;

                    Comando.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }


}

