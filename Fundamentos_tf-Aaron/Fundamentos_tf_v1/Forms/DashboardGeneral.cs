using Fundamentos_tf_v1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos_tf_v1.Forms
{
    public partial class DashboardGeneral : Form
    {
        public DashboardGeneral()
        {
            InitializeComponent();
        }

        private void DashboardGeneral_Load(object sender, EventArgs e)
        {
            if (MemoriaTemporal.UsuarioActual != null)
            {
                lblUsuario.Text =MemoriaTemporal.UsuarioActual.Nombre.ToUpper() + "\n(" + MemoriaTemporal.UsuarioActual.Rol + ")";

                if (MemoriaTemporal.UsuarioActual.Rol != "Administrador")
                {
                    btnReportes.Visible = false;
                }
            }
            CargarTickets("Todos");
        }
        private void CargarTickets(string estadoFiltro)
        {
            var listaFiltrada = MemoriaTemporal.Tickets.AsEnumerable();
            if (estadoFiltro != "Todos")
            {
                listaFiltrada = listaFiltrada.Where(t => t.Estado == estadoFiltro);
            }

            dgvTarjetaTickets.DataSource = null;
            dgvTarjetaTickets.DataSource = listaFiltrada.ToList();

            if (dgvTarjetaTickets.Columns["IdColaborador"] != null) dgvTarjetaTickets.Columns["IdColaborador"].Visible = false;
            if (dgvTarjetaTickets.Columns["IdTecnico"] != null) dgvTarjetaTickets.Columns["IdTecnico"].Visible = false;
            if (dgvTarjetaTickets.Columns["CreadoPor"] != null) dgvTarjetaTickets.Columns["CreadoPor"].Visible = false;
        }
        private void btnTicketsRegistrados_Click(object sender, EventArgs e)
        {
            CargarTickets("Registrado");
        }

        private void btnTicketsEvaluacion_Click(object sender, EventArgs e)
        {
            CargarTickets("En Evaluación");
        }

        private void btnTicketsResueltos_Click(object sender, EventArgs e)
        {
            CargarTickets("Resuelto");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CargarTickets("Todos");
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            InformacionAuditoria pantallaAuditoria = new InformacionAuditoria();
            pantallaAuditoria.Show();
        }

        private void btnMisTickets_Click(object sender, EventArgs e)
        {
            Mistickets misTickets = new Mistickets();
            misTickets.Show();
            this.Hide();
        }
    }
}
