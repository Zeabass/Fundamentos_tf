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
    public partial class MisCasosTecnico : Form
    {
        public MisCasosTecnico()
        {
            InitializeComponent();
        }

        private void MisCasosTecnico_Load(object sender, EventArgs e)
        {
            if (MemoriaTemporal.UsuarioActual != null)
            {
                lblUsuario.Text =" " + MemoriaTemporal.UsuarioActual.Nombre.ToUpper() + "\n(Técnico)";
                CargarMisCasos();
            }
        }
        private void CargarMisCasos()
        {
            var misCasos = MemoriaTemporal.Tickets
                .Where(t => t.IdTecnico == MemoriaTemporal.UsuarioActual.IdUsuario)
                .ToList();

            dgvMisCasos.DataSource = null;
            dgvMisCasos.DataSource = misCasos;

            if (dgvMisCasos.Columns["IdColaborador"] != null) dgvMisCasos.Columns["IdColaborador"].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            BandejaTecnico inicio = new BandejaTecnico();
            inicio.Show();
            this.Close();
        }
    }
}
