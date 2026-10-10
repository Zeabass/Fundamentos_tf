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
    public partial class InformacionAuditoria : Form
    {
        public InformacionAuditoria()
        {
            InitializeComponent();
        }

        private void InformacionAuditoria_Load(object sender, EventArgs e)
        {
            if (MemoriaTemporal.UsuarioActual != null)
            {
                lblUsuario.Text = MemoriaTemporal.UsuarioActual.Nombre.ToUpper();
            }
            cmbBuscarTicket.Items.Clear();
            foreach (var ticket in MemoriaTemporal.Tickets)
            {
                cmbBuscarTicket.Items.Add(ticket.IdTicket);
            }
        }

        private void cmbBuscarTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarTicket.SelectedItem == null) return;

            int idBuscado = (int)cmbBuscarTicket.SelectedItem;

            // Buscamos el ticket
            var ticket = MemoriaTemporal.Tickets.FirstOrDefault(t => t.IdTicket == idBuscado);

            if (ticket != null)
            {
                txtTitulo.Text = ticket.Titulo;
                txtCategoria.Text = ticket.Categoria;
                txtPrioridad.Text = ticket.Prioridad;

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
                var historial = MemoriaTemporal.Historiales.LastOrDefault(h => h.IdTicket == idBuscado);

                if (historial != null && !string.IsNullOrEmpty(historial.Comentario))
                {
                    txtDescripcion.Text = $"DESCRIPCIÓN ORIGINAL:\n{ticket.Descripcion}\n\n" +
                                          $"--- SOLUCIÓN DEL TÉCNICO (ID: {historial.IdTecnico}) ---\n" +
                                          $"{historial.Comentario}";
                }
                else
                {
                    txtDescripcion.Text = ticket.Descripcion;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
