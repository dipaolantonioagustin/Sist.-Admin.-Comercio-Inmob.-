using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FRPrincipal : Form
    {
        public FRPrincipal()
        {
            InitializeComponent();
        }

        private void inquilinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRInquilino Inquilino = new FRInquilino();

            Inquilino.MdiParent = this;

            Inquilino.Show();
        }

        private void propietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRPropietario propietario = new FRPropietario();
            propietario.MdiParent = this;
            propietario.Show();
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRPropiedad propiedades = new FRPropiedad();
            propiedades.MdiParent = this;
            propiedades.Show();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRLocalidad localidades = new FRLocalidad();
            localidades.MdiParent = this;
            localidades.Show();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRCaja caja = new FRCaja();
            caja.MdiParent = this;
            caja.Show();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRReportes reportes = new FRReportes();
            reportes.MdiParent = this;
            reportes.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRContrato contrato = new FRContrato();
            contrato.MdiParent = this;
            contrato.Show();
        }

        private void reportePropiedadesDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRReporte1 disponibles = new FRReporte1();
            disponibles.MdiParent = this;
            disponibles.Show();
        }

        private void reporteCajaAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRReporte2 cajaAlquileres = new FRReporte2();
            cajaAlquileres.MdiParent = this;
            cajaAlquileres.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporteCajaChicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRReporte3 cajaChica = new FRReporte3();
            cajaChica.MdiParent = this;
            cajaChica.Show();
        }

        private void cajaChicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FRCajaChica cajaChicaCarga = new FRCajaChica();
            cajaChicaCarga.MdiParent = this;
            cajaChicaCarga.Show();
        }
    }
}
