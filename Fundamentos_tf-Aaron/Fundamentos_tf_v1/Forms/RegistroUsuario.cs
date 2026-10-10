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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            //cmbRol.Items.Add("Administrador");
            //cmbRol.Items.Add("Tecnico");
            //cmbRol.Items.Add("Colaborador");
        }

        private void btnGuardarReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoReg.Text) ||
                string.IsNullOrWhiteSpace(txtClaveReg.Text) ||
                cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos y selecciona un rol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nuevoId = MemoriaTemporal.Usuarios.Count + 1001;

            Usuario nuevoUsuario = new Usuario
            {
                IdUsuario = nuevoId,
                Nombre = txtNombre.Text,
                Correo = txtCorreoReg.Text,
                Clave = txtClaveReg.Text,
                Rol = cmbRol.SelectedItem.ToString(),
                Activo = true,

                CreadoPor = nuevoId,
                CreadoTiempo = DateTime.Now
            };
            MemoriaTemporal.Usuarios.Add(nuevoUsuario);

            MessageBox.Show("¡Registro exitoso! Ya puedes iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            VolverAlLogin();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VolverAlLogin();
        }
        private void VolverAlLogin()
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
