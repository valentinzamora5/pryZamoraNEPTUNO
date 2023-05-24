namespace pryZamoraNEPTUNO
{
    partial class FrmTablas
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
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.lblTabla = new System.Windows.Forms.Label();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseDatos.Location = new System.Drawing.Point(12, 29);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(88, 15);
            this.lblBaseDatos.TabIndex = 0;
            this.lblBaseDatos.Text = "Base de datos:";
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(122, 29);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.ReadOnly = true;
            this.txtBaseDatos.Size = new System.Drawing.Size(100, 20);
            this.txtBaseDatos.TabIndex = 6;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(261, 30);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(41, 15);
            this.lblTabla.TabIndex = 7;
            this.lblTabla.Text = "Tabla:";
            // 
            // cmbTablas
            // 
            this.cmbTablas.Enabled = false;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(320, 28);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(121, 21);
            this.cmbTablas.TabIndex = 8;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBaseDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBaseDatos.FlatAppearance.BorderSize = 0;
            this.btnBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseDatos.Location = new System.Drawing.Point(122, 88);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(133, 53);
            this.btnBaseDatos.TabIndex = 9;
            this.btnBaseDatos.Text = "Seleccionar una BD";
            this.btnBaseDatos.UseVisualStyleBackColor = false;
            this.btnBaseDatos.Click += new System.EventHandler(this.btnBaseDatos_Click);
            // 
            // dgvTablas
            // 
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(12, 156);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.Size = new System.Drawing.Size(518, 306);
            this.dgvTablas.TabIndex = 10;
            // 
            // FrmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(587, 510);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.btnBaseDatos);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.txtBaseDatos);
            this.Controls.Add(this.lblBaseDatos);
            this.Name = "FrmTablas";
            this.Text = "Tablas";
            this.Load += new System.EventHandler(this.FrmTablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.Button btnBaseDatos;
        private System.Windows.Forms.DataGridView dgvTablas;
    }
}