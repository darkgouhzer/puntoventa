using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Form1 : Form
    {

        private Form formActivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            btnInactivar();            
            btnCatalogos.BackColor = Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            AbrirForm(new Principal.Catalogos.Catalogo());

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            btnInactivar();            
            btnVentas.BackColor = Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            AbrirForm(new Principal.Venta.Ventas());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            btnInactivar();            
            btnInventario.BackColor = Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            AbrirForm(new Principal.Inventario.Inventario());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            btnInactivar();            
            btnReportes.BackColor = Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            AbrirForm(new Principal.Reportes.Reportes());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            btnInactivar();            
            btnConfiguracion.BackColor = Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            AbrirForm(new Principal.Configuracion.Configuracion());
        }

        private void btnInactivar()
        {
        //    panelConfiguracion.Visible = panelInventario.Visible = panelVentas.Visible = panelReportes.Visible = panelCatalogos.Visible = false;
            btnReportes.BackColor = btnInventario.BackColor = btnVentas.BackColor = btnCatalogos.BackColor = btnConfiguracion.BackColor =
                Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            
        }

        public void AbrirForm(Form objForm)
        {
            if(formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = objForm;
            objForm.TopLevel = false;
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;            
            this.panelPrincipal.Controls.Add(objForm);
            this.panelPrincipal.Tag = objForm;
            objForm.BringToFront();
            objForm.Show();
            lblTitle.Text = objForm.Text;
            btnCerrarForm.Visible = true;
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            if (formActivo != null)
            {
                formActivo.Close();
                btnInactivar();
                lblTitle.Text = "Inicio";
                btnCerrarForm.Visible = false;
            }


        }
    }
}
