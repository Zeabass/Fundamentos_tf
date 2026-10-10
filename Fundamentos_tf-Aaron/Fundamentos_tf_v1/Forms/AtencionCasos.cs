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
    public partial class AtencionCasos : Form
    {
        public AtencionCasos()
        {
            InitializeComponent();
        }

        private void AtencionCasos_Load(object sender, EventArgs e)
        {
            if (MemoriaTemporal.UsuarioActual != null)
            {
                lblRolUsuario.Text = "Usuario:\n" + MemoriaTemporal.UsuarioActual.Nombre.ToUpper() + "\n(Técnico)";
            }
            cmbEstado.Items.Add("En Evaluación");
            cmbEstado.Items.Add("Resuelto");

            foreach (var ticket in MemoriaTemporal.Tickets)
            {
                cmbCasoAsignado.Items.Add(ticket.IdTicket);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCasoAsignado.SelectedItem == null || cmbEstado.SelectedItem == null || string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Por favor, selecciona un ID, el estado y redacta un comentario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSeleccionado = (int)cmbCasoAsignado.SelectedItem;
            var ticket = MemoriaTemporal.Tickets.FirstOrDefault(t => t.IdTicket == idSeleccionado);

            if (ticket != null)
            {
                ticket.Estado = cmbEstado.SelectedItem.ToString();
                ticket.IdTecnico = MemoriaTemporal.UsuarioActual.IdUsuario;
                ticket.ModificadoPor = MemoriaTemporal.UsuarioActual.IdUsuario;
                ticket.ModificadoEn = DateTime.Now;
                int nuevoIdHistorial = MemoriaTemporal.Historiales.Count + 1;
                HistorialAtencion nuevoHistorial = new HistorialAtencion
                {
                    IdHistorial = nuevoIdHistorial,
                    IdTicket = ticket.IdTicket,
                    IdTecnico = MemoriaTemporal.UsuarioActual.IdUsuario,
                    Comentario = txtComentario.Text,
                    Solucion = cmbEstado.SelectedItem.ToString() == "Resuelto" ? txtComentario.Text : "",
                    FechaAtencion = DateTime.Now,
                    CreadoPor = MemoriaTemporal.UsuarioActual.IdUsuario,
                    CreadoTiempo = DateTime.Now
                };

                MemoriaTemporal.Historiales.Add(nuevoHistorial);

                MessageBox.Show($"¡Éxito! El caso #{ticket.IdTicket} pasó a estado: {ticket.Estado}.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCasoAsignado.SelectedIndex = -1;
                cmbEstado.SelectedIndex = -1;
                txtComentario.Clear();
            }
        }
        private void btnCerrarCaso_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            BandejaTecnico inicio = new BandejaTecnico();
            inicio.Show();
            this.Close();
        }

        private void btnMisCasos_Click(object sender, EventArgs e)
        {
            MisCasosTecnico misCasos = new MisCasosTecnico();
            misCasos.Show();
            this.Close();
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            DetalleTicket detalleTicket = new DetalleTicket();
            detalleTicket.Show();
            this.Close();
        }
    }
}
