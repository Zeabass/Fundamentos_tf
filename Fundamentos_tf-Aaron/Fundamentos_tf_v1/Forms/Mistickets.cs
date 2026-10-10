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
    public partial class Mistickets : Form
    {
        public Mistickets()
        {
            InitializeComponent();
        }

        private void Mistickets_Load(object sender, EventArgs e)
        {
            if (MemoriaTemporal.UsuarioActual != null)
            {
                lblUsuario.Text = "Usuario: " + MemoriaTemporal.UsuarioActual.Nombre.ToUpper();
            }
            CargarMisTickets();
        }
        private void CargarMisTickets()
        {
            if (MemoriaTemporal.UsuarioActual != null)
            {
                var misCasos = MemoriaTemporal.Tickets.Where(t => t.IdColaborador == MemoriaTemporal.UsuarioActual.IdUsuario).ToList();

                dgvTickets.DataSource = null;
                dgvTickets.DataSource = misCasos;
            }
        }

        private void btnSubirTicket_Click(object sender, EventArgs e)
        {
            RegistroTicket registro = new RegistroTicket();
            registro.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
