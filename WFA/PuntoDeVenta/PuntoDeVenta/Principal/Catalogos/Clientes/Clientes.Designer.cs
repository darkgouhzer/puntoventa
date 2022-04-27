namespace PuntoDeVenta.Principal.Catalogos
{
    partial class Clientes
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblProductoId = new System.Windows.Forms.Label();
            this.btnAltas = new System.Windows.Forms.Button();
            this.tbxProductoId = new System.Windows.Forms.TextBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.colProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(754, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 40);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblProductoId
            // 
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.Location = new System.Drawing.Point(18, 15);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(52, 17);
            this.lblProductoId.TabIndex = 17;
            this.lblProductoId.Text = "Código";
            // 
            // btnAltas
            // 
            this.btnAltas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnAltas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltas.ForeColor = System.Drawing.Color.White;
            this.btnAltas.Location = new System.Drawing.Point(615, 24);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(133, 40);
            this.btnAltas.TabIndex = 22;
            this.btnAltas.Text = "Altas - modificar";
            this.btnAltas.UseVisualStyleBackColor = false;
            // 
            // tbxProductoId
            // 
            this.tbxProductoId.Location = new System.Drawing.Point(106, 12);
            this.tbxProductoId.Name = "tbxProductoId";
            this.tbxProductoId.Size = new System.Drawing.Size(100, 23);
            this.tbxProductoId.TabIndex = 16;
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductoID,
            this.colNombreCliente,
            this.colDomicilio,
            this.colTelefono,
            this.colColonia,
            this.colCiudad});
            this.dtgClientes.Location = new System.Drawing.Point(12, 70);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(842, 458);
            this.dtgClientes.TabIndex = 20;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(106, 41);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(278, 23);
            this.tbxDescripcion.TabIndex = 18;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 47);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripción";
            // 
            // colProductoID
            // 
            this.colProductoID.HeaderText = "Código";
            this.colProductoID.Name = "colProductoID";
            this.colProductoID.ReadOnly = true;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.HeaderText = "Nombre";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.ReadOnly = true;
            this.colNombreCliente.Width = 250;
            // 
            // colDomicilio
            // 
            this.colDomicilio.HeaderText = "Domicilio";
            this.colDomicilio.Name = "colDomicilio";
            this.colDomicilio.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colColonia
            // 
            this.colColonia.HeaderText = "Colonia";
            this.colColonia.Name = "colColonia";
            this.colColonia.ReadOnly = true;
            // 
            // colCiudad
            // 
            this.colCiudad.HeaderText = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.ReadOnly = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(873, 540);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblProductoId);
            this.Controls.Add(this.btnAltas);
            this.Controls.Add(this.tbxProductoId);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblProductoId;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.TextBox tbxProductoId;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudad;
    }
}