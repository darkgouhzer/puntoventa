namespace PuntoDeVenta.Principal.Catalogos.Productos
{
    partial class Producto
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
            this.lblProductoId = new System.Windows.Forms.Label();
            this.tbxProductoId = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioMaryoreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalMayoreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAltas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductoId
            // 
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.Location = new System.Drawing.Point(18, 15);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(52, 17);
            this.lblProductoId.TabIndex = 3;
            this.lblProductoId.Text = "Código";
            // 
            // tbxProductoId
            // 
            this.tbxProductoId.Location = new System.Drawing.Point(106, 12);
            this.tbxProductoId.Name = "tbxProductoId";
            this.tbxProductoId.Size = new System.Drawing.Size(100, 23);
            this.tbxProductoId.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 47);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 23);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductoID,
            this.colDescripcion,
            this.colExistencias,
            this.colPrecio,
            this.colPrecioMaryoreo,
            this.colTotalPrecio,
            this.colTotalMayoreo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(813, 458);
            this.dataGridView1.TabIndex = 6;
            // 
            // colProductoID
            // 
            this.colProductoID.HeaderText = "Código";
            this.colProductoID.Name = "colProductoID";
            this.colProductoID.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colExistencias
            // 
            this.colExistencias.HeaderText = "Existencias";
            this.colExistencias.Name = "colExistencias";
            this.colExistencias.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colPrecioMaryoreo
            // 
            this.colPrecioMaryoreo.HeaderText = "Precio mayoreo";
            this.colPrecioMaryoreo.Name = "colPrecioMaryoreo";
            this.colPrecioMaryoreo.ReadOnly = true;
            // 
            // colTotalPrecio
            // 
            this.colTotalPrecio.HeaderText = "Total precio";
            this.colTotalPrecio.Name = "colTotalPrecio";
            this.colTotalPrecio.ReadOnly = true;
            // 
            // colTotalMayoreo
            // 
            this.colTotalMayoreo.HeaderText = "Total Mayoreo";
            this.colTotalMayoreo.Name = "colTotalMayoreo";
            this.colTotalMayoreo.ReadOnly = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(725, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 40);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAltas
            // 
            this.btnAltas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnAltas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltas.ForeColor = System.Drawing.Color.White;
            this.btnAltas.Location = new System.Drawing.Point(619, 12);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(100, 40);
            this.btnAltas.TabIndex = 8;
            this.btnAltas.Text = "Altas";
            this.btnAltas.UseVisualStyleBackColor = false;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(837, 540);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblProductoId);
            this.Controls.Add(this.btnAltas);
            this.Controls.Add(this.tbxProductoId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDescripcion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Producto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Producto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductoId;
        private System.Windows.Forms.TextBox tbxProductoId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioMaryoreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalMayoreo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnAltas;
    }
}