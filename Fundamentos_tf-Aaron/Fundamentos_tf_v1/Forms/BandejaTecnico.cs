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
    public partial class BandejaTecnico : Form
    {
        public BandejaTecnico()
        {
            InitializeComponent();
        }

        private void BandejaTecnico_Load(object sender, EventArgs e)
        {
            if (MemoriaTemporal.UsuarioActual != null)
            {
                lblUsuario.Text = MemoriaTemporal.UsuarioActual.Nombre.ToUpper() + "\n(Técnico)";
            }

            CargarTicketsPendientes();
        }
        private void CargarTicketsPendientes()
        {
            var ticketsPendientes = MemoriaTemporal.Tickets
                .Where(t => t.Estado == "Registrado" || t.Estado == "En Evaluación")
                .ToList();

            dgvTicketsPendientes.DataSource = null;
            dgvTicketsPendientes.DataSource = ticketsPendientes;

            if (dgvTicketsPendientes.Columns["IdColaborador"] != null) dgvTicketsPendientes.Columns["IdColaborador"].Visible = false;
        }
        private void btnAtenderCaso_Click(object sender, EventArgs e)
        {
            AtencionCasos atencion = new AtencionCasos();
            atencion.Show();
            this.Hide();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
