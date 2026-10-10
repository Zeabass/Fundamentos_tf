using Fundamentos_tf_v1.Entidades;
using Fundamentos_tf_v1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos_tf_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor, ingresa tu correo y contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioEncontrado = MemoriaTemporal.Usuarios.FirstOrDefault(u =>
                u.Correo == txtCorreo.Text && u.Clave == txtClave.Text && u.Activo == true);

            if (usuarioEncontrado != null)
            {
                MemoriaTemporal.UsuarioActual = usuarioEncontrado;

                MessageBox.Show("¡Ingreso exitoso!\nBienvenido: " + usuarioEncontrado.Nombre + "\nRol: " + usuarioEncontrado.Rol, "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (usuarioEncontrado.Rol == "Administrador")
                {
                    DashboardGeneral dashboard = new DashboardGeneral();
                    dashboard.Show();
                }
                else if (usuarioEncontrado.Rol == "Tecnico")
                {
                    BandejaTecnico inicioTecnico = new BandejaTecnico();
                    inicioTecnico.Show();
                    this.Hide();
                }
                else if (usuarioEncontrado.Rol == "Colaborador")
                {
                    Mistickets misTickets = new Mistickets();
                    misTickets.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.Show();
            this.Hide();
        }
    }
}
