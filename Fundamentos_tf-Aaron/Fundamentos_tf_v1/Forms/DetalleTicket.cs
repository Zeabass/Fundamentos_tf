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
    public partial class DetalleTicket : Form
    {
        public DetalleTicket()
        {
            InitializeComponent();
        }

        private void DetalleTicket_Load(object sender, EventArgs e)
        {
            if (MemoriaTemporal.UsuarioActual != null)
            {
                lblSidebarUsuario.Text = MemoriaTemporal.UsuarioActual.Nombre.ToUpper() + "\n(TÉCNICO)";
                lblFooterUsuario.Text =MemoriaTemporal.UsuarioActual.Nombre.ToUpper();
            }
            txtTitulo.ReadOnly = true;
            txtCategoria.ReadOnly = true;
            cmbActualizarEstado.Items.Clear();
            cmbActualizarEstado.Items.Add("En Evaluación");
            cmbActualizarEstado.Items.Add("Resuelto");

            cmbMisCasos.Items.Clear();
            if (MemoriaTemporal.UsuarioActual != null)
            {
                var misTickets = MemoriaTemporal.Tickets
                    .Where(t => t.IdTecnico == MemoriaTemporal.UsuarioActual.IdUsuario)
                    .ToList();

                foreach (var ticket in misTickets)
                {
                    cmbMisCasos.Items.Add(ticket.IdTicket);
                }
            }
        }
        private void cmbMisCasos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMisCasos.SelectedItem == null) return;

            int idSeleccionado = (int)cmbMisCasos.SelectedItem;
            var ticket = MemoriaTemporal.Tickets.FirstOrDefault(t => t.IdTicket == idSeleccionado);

            if (ticket != null)
            {
                txtTitulo.Text = ticket.Titulo;
                txtCategoria.Text = ticket.Categoria;
                cmbActualizarEstado.SelectedItem = ticket.Estado;

                lblCreateBy.Text = ticket.CreadoPor.ToString();
                lblCreatedAt.Text = ticket.CreadoTiempo.ToString("dd/MM/yyyy HH:mm");

                if (ticket.ModificadoPor != null)
                {
                    lblModifiedBy.Text = ticket.ModificadoPor.ToString();
                    lblModifiedAt.Text = ticket.ModificadoEn?.ToString("dd/MM/yyyy HH:mm");
                }
                else
                {
                    lblModifiedBy.Text = "Nadie aún";
                    lblModifiedAt.Text = "-";
                }
                string historialTexto = $"[PROBLEMA REPORTADO]:\r\n{ticket.Descripcion}\r\n\r\n" +
                                        "--------------------------------------------------\r\n" +
                                        "[NUEVA SOLUCIÓN / COMENTARIO]:\r\n";

                txtComentario.Text = historialTexto;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbMisCasos.SelectedItem == null || cmbMisCasos.SelectedItem == null || string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Por favor, selecciona un ID, actualiza el estado y escribe un comentario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSeleccionado = (int)cmbMisCasos.SelectedItem;
            var ticket = MemoriaTemporal.Tickets.FirstOrDefault(t => t.IdTicket == idSeleccionado);

            if (ticket != null)
            {
                ticket.Estado = cmbActualizarEstado.SelectedItem.ToString();
                ticket.ModificadoPor = MemoriaTemporal.UsuarioActual.IdUsuario;
                ticket.ModificadoEn = DateTime.Now;

                MemoriaTemporal.Historiales.Add(new HistorialAtencion
                {
                    IdHistorial = MemoriaTemporal.Historiales.Count + 1,
                    IdTicket = ticket.IdTicket,
                    IdTecnico = MemoriaTemporal.UsuarioActual.IdUsuario,
                    Comentario = txtComentario.Text,
                    Solucion = ticket.Estado == "Resuelto" ? "Caso Resuelto" : "En proceso",
                    FechaAtencion = DateTime.Now
                });

                MessageBox.Show($"¡El Ticket #{ticket.IdTicket} ha sido modificado y actualizado con éxito!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMisCasos.SelectedIndex = -1;
                txtTitulo.Clear();
                txtCategoria.Clear();
                cmbActualizarEstado.SelectedIndex = -1;
                txtComentario.Clear();
                lblCreateBy.Text = "-";
                lblModifiedBy.Text = "-";
                lblCreatedAt.Text = "-";
                lblModifiedAt.Text = "-";
            }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
