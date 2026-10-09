namespace Fundamentos_tf_v1.Forms
{
    partial class AtencionCasos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnMisCasos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblTituloSidebar = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTarjetaBlanca = new System.Windows.Forms.Panel();
            this.btnCerrarCaso = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbCasoAsignado = new System.Windows.Forms.ComboBox();
            this.lblCasoAsignado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTarjetaBlanca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnMisCasos);
            this.pnlSidebar.Controls.Add(this.btnInicio);
            this.pnlSidebar.Controls.Add(this.lblRolUsuario);
            this.pnlSidebar.Controls.Add(this.lblTituloSidebar);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(160, 480);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnMisCasos
            // 
            this.btnMisCasos.BackColor = System.Drawing.Color.Gray;
            this.btnMisCasos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisCasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisCasos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisCasos.ForeColor = System.Drawing.Color.White;
            this.btnMisCasos.Location = new System.Drawing.Point(18, 140);
            this.btnMisCasos.Name = "btnMisCasos";
            this.btnMisCasos.Size = new System.Drawing.Size(124, 28);
            this.btnMisCasos.TabIndex = 3;
            this.btnMisCasos.Text = "Mis Casos";
            this.btnMisCasos.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Gray;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(18, 102);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(124, 28);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblRolUsuario.Location = new System.Drawing.Point(15, 52);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(107, 30);
            this.lblRolUsuario.TabIndex = 1;
            this.lblRolUsuario.Text = "Usuario:\r\nTECNICO";
            // 
            // lblTituloSidebar
            // 
            this.lblTituloSidebar.AutoSize = true;
            this.lblTituloSidebar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSidebar.ForeColor = System.Drawing.Color.Black;
            this.lblTituloSidebar.Location = new System.Drawing.Point(14, 18);
            this.lblTituloSidebar.Name = "lblTituloSidebar";
            this.lblTituloSidebar.Size = new System.Drawing.Size(100, 22);
            this.lblTituloSidebar.TabIndex = 0;
            this.lblTituloSidebar.Text = "HelpDesk";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(188)))), ((int)(((byte)(233)))));
            this.pnlMain.Controls.Add(this.pnlTarjetaBlanca);
            this.pnlMain.Controls.Add(this.lblTitulo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(160, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(730, 480);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlTarjetaBlanca
            // 
            this.pnlTarjetaBlanca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTarjetaBlanca.BackColor = System.Drawing.Color.White;
            this.pnlTarjetaBlanca.Controls.Add(this.btnCerrarCaso);
            this.pnlTarjetaBlanca.Controls.Add(this.btnGuardar);
            this.pnlTarjetaBlanca.Controls.Add(this.txtComentario);
            this.pnlTarjetaBlanca.Controls.Add(this.lblComentario);
            this.pnlTarjetaBlanca.Controls.Add(this.cmbEstado);
            this.pnlTarjetaBlanca.Controls.Add(this.lblEstado);
            this.pnlTarjetaBlanca.Controls.Add(this.cmbCasoAsignado);
            this.pnlTarjetaBlanca.Controls.Add(this.lblCasoAsignado);
            this.pnlTarjetaBlanca.Location = new System.Drawing.Point(20, 60);
            this.pnlTarjetaBlanca.Name = "pnlTarjetaBlanca";
            this.pnlTarjetaBlanca.Size = new System.Drawing.Size(690, 400);
            this.pnlTarjetaBlanca.TabIndex = 1;
            // 
            // btnCerrarCaso
            // 
            this.btnCerrarCaso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarCaso.BackColor = System.Drawing.Color.Gray;
            this.btnCerrarCaso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCaso.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaso.ForeColor = System.Drawing.Color.White;
            this.btnCerrarCaso.Location = new System.Drawing.Point(545, 345);
            this.btnCerrarCaso.Name = "btnCerrarCaso";
            this.btnCerrarCaso.Size = new System.Drawing.Size(120, 36);
            this.btnCerrarCaso.TabIndex = 7;
            this.btnCerrarCaso.Text = "Cerrar caso";
            this.btnCerrarCaso.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(415, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 36);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComentario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(20, 105);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(645, 225);
            this.txtComentario.TabIndex = 5;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.Color.Black;
            this.lblComentario.Location = new System.Drawing.Point(17, 82);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(175, 15);
            this.lblComentario.TabIndex = 4;
            this.lblComentario.Text = "Comentario/Solución aplicada:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(340, 42);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(180, 23);
            this.cmbEstado.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(337, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(107, 15);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Actualizar estado:";
            // 
            // cmbCasoAsignado
            // 
            this.cmbCasoAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCasoAsignado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCasoAsignado.FormattingEnabled = true;
            this.cmbCasoAsignado.Location = new System.Drawing.Point(20, 42);
            this.cmbCasoAsignado.Name = "cmbCasoAsignado";
            this.cmbCasoAsignado.Size = new System.Drawing.Size(180, 23);
            this.cmbCasoAsignado.TabIndex = 1;
            // 
            // lblCasoAsignado
            // 
            this.lblCasoAsignado.AutoSize = true;
            this.lblCasoAsignado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasoAsignado.ForeColor = System.Drawing.Color.Black;
            this.lblCasoAsignado.Location = new System.Drawing.Point(17, 20);
            this.lblCasoAsignado.Name = "lblCasoAsignado";
            this.lblCasoAsignado.Size = new System.Drawing.Size(126, 15);
            this.lblCasoAsignado.TabIndex = 0;
            this.lblCasoAsignado.Text = "ID del caso asignado:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Atención de Casos";
            // 
            // AtencionCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 480);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AtencionCasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpDesk - Atención de Casos";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTarjetaBlanca.ResumeLayout(false);
            this.pnlTarjetaBlanca.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblTituloSidebar;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMisCasos;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTarjetaBlanca;
        private System.Windows.Forms.Label lblCasoAsignado;
        private System.Windows.Forms.ComboBox cmbCasoAsignado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrarCaso;
    }
}