namespace PuntoDeVenta.Principal.Catalogos.Productos
{
    partial class AltaProducto
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxProductoId = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPrecioLista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPrecioMayoreo = new System.Windows.Forms.TextBox();
            this.cbxUnidadesMedida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxValorMedida = new System.Windows.Forms.TextBox();
            this.lblValormedida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductoId
            // 
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.Location = new System.Drawing.Point(12, 15);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(52, 17);
            this.lblProductoId.TabIndex = 10;
            this.lblProductoId.Text = "Código";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(320, 195);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // tbxProductoId
            // 
            this.tbxProductoId.Location = new System.Drawing.Point(141, 12);
            this.tbxProductoId.MaxLength = 9;
            this.tbxProductoId.Name = "tbxProductoId";
            this.tbxProductoId.Size = new System.Drawing.Size(100, 23);
            this.tbxProductoId.TabIndex = 1;
            this.tbxProductoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxProductoId_KeyDown);
            this.tbxProductoId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductoId_KeyPress);
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(141, 41);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(278, 23);
            this.tbxDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 44);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Precio";
            // 
            // tbxPrecioLista
            // 
            this.tbxPrecioLista.Location = new System.Drawing.Point(141, 129);
            this.tbxPrecioLista.Name = "tbxPrecioLista";
            this.tbxPrecioLista.Size = new System.Drawing.Size(100, 23);
            this.tbxPrecioLista.TabIndex = 5;
            this.tbxPrecioLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecioLista_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Precio mayoreo";
            // 
            // tbxPrecioMayoreo
            // 
            this.tbxPrecioMayoreo.Location = new System.Drawing.Point(141, 158);
            this.tbxPrecioMayoreo.Name = "tbxPrecioMayoreo";
            this.tbxPrecioMayoreo.Size = new System.Drawing.Size(100, 23);
            this.tbxPrecioMayoreo.TabIndex = 6;
            this.tbxPrecioMayoreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecioLista_KeyPress);
            // 
            // cbxUnidadesMedida
            // 
            this.cbxUnidadesMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadesMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnidadesMedida.FormattingEnabled = true;
            this.cbxUnidadesMedida.Location = new System.Drawing.Point(141, 99);
            this.cbxUnidadesMedida.Name = "cbxUnidadesMedida";
            this.cbxUnidadesMedida.Size = new System.Drawing.Size(184, 24);
            this.cbxUnidadesMedida.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Unidad de medida";
            // 
            // tbxValorMedida
            // 
            this.tbxValorMedida.Location = new System.Drawing.Point(141, 70);
            this.tbxValorMedida.Name = "tbxValorMedida";
            this.tbxValorMedida.Size = new System.Drawing.Size(100, 23);
            this.tbxValorMedida.TabIndex = 3;
            this.tbxValorMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecioLista_KeyPress);
            // 
            // lblValormedida
            // 
            this.lblValormedida.AutoSize = true;
            this.lblValormedida.Location = new System.Drawing.Point(12, 73);
            this.lblValormedida.Name = "lblValormedida";
            this.lblValormedida.Size = new System.Drawing.Size(91, 17);
            this.lblValormedida.TabIndex = 22;
            this.lblValormedida.Text = "Valor medida";
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(432, 247);
            this.Controls.Add(this.tbxValorMedida);
            this.Controls.Add(this.lblValormedida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxUnidadesMedida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPrecioMayoreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrecioLista);
            this.Controls.Add(this.lblProductoId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbxProductoId);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaProducto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de producto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AltaProducto_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductoId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxProductoId;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPrecioLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPrecioMayoreo;
        private System.Windows.Forms.ComboBox cbxUnidadesMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxValorMedida;
        private System.Windows.Forms.Label lblValormedida;
    }
}