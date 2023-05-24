namespace pryZamoraNEPTUNO
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "País:";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(94, 84);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 3;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(339, 83);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 4;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.Nombre_Compania,
            this.Nombre_Contacto,
            this.Cargo_Contacto,
            this.Direccion,
            this.Ciudad,
            this.Region,
            this.Codigo_Postal,
            this.Pais,
            this.Telefono,
            this.Fax});
            this.dgvClientes.Location = new System.Drawing.Point(38, 135);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(570, 252);
            this.dgvClientes.TabIndex = 5;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "Id. de Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.Width = 87;
            // 
            // Nombre_Compania
            // 
            this.Nombre_Compania.HeaderText = "Nombre de compañia";
            this.Nombre_Compania.Name = "Nombre_Compania";
            this.Nombre_Compania.Width = 122;
            // 
            // Nombre_Contacto
            // 
            this.Nombre_Contacto.HeaderText = "Nombre del contacto";
            this.Nombre_Contacto.Name = "Nombre_Contacto";
            this.Nombre_Contacto.Width = 120;
            // 
            // Cargo_Contacto
            // 
            this.Cargo_Contacto.HeaderText = "Cargo del contacto";
            this.Cargo_Contacto.Name = "Cargo_Contacto";
            this.Cargo_Contacto.Width = 112;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 77;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 65;
            // 
            // Region
            // 
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            this.Region.Width = 66;
            // 
            // Codigo_Postal
            // 
            this.Codigo_Postal.HeaderText = "Código Postal";
            this.Codigo_Postal.Name = "Codigo_Postal";
            this.Codigo_Postal.Width = 89;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "País";
            this.Pais.Name = "Pais";
            this.Pais.Width = 54;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 74;
            // 
            // Fax
            // 
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.Width = 49;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListar.Location = new System.Drawing.Point(496, 412);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(112, 38);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(660, 503);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "Listado de clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.Button btnListar;
    }
}