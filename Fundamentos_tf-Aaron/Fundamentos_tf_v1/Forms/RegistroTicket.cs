using Fundamentos_tf_v1.Entidades;
using Fundamentos_tf_v1.Entities;
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
    public partial class RegistroTicket : Form
    {
        public RegistroTicket()
        {
            InitializeComponent();
        }

        private void RegistroTicket_Load(object sender, EventArgs e)
        {
            if (MemoriaTemporal.UsuarioActual != null)
            {
                lblUsuario.Text = "Usuario: " + MemoriaTemporal.UsuarioActual.Nombre.ToUpper();
            }
        }

        private void btnSubirTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                cmbCategoria.SelectedItem == null ||
                cmbPrioridad.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos para registrar el ticket.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int nuevoId = MemoriaTemporal.Tickets.Count > 0 ? MemoriaTemporal.Tickets.Max(t => t.IdTicket) + 1 : 1;

            Ticket nuevoTicket = new Ticket
            {
                IdTicket = nuevoId,
                Titulo = txtTitulo.Text,
                Descripcion = txtDescripcion.Text,
                Categoria = cmbCategoria.SelectedItem.ToString(),
                Prioridad = cmbPrioridad.SelectedItem.ToString(),
                Estado = "Registrado", 
                IdColaborador = MemoriaTemporal.UsuarioActual.IdUsuario,
                CreadoPor = MemoriaTemporal.UsuarioActual.IdUsuario,
                CreadoTiempo = DateTime.Now
            };
            MemoriaTemporal.Tickets.Add(nuevoTicket);

            MessageBox.Show("¡Ticket registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Mistickets misTickets = new Mistickets();
            misTickets.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Mistickets misTickets = new Mistickets();
            misTickets.Show();
            this.Close();
        }
    }
}
