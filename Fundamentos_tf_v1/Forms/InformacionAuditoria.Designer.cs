namespace Fundamentos_tf_v1.Forms
{
    partial class InformacionAuditoria
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloProblema = new System.Windows.Forms.Label();
            this.txtTituloProblema = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCreadoPor = new System.Windows.Forms.Label();
            this.txtCreadoPor = new System.Windows.Forms.TextBox();
            this.lblModificadoPor = new System.Windows.Forms.Label();
            this.txtModificadoPor = new System.Windows.Forms.TextBox();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.txtFechaModificacion = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(365, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Información de Auditoría";
            // 
            // lblTituloProblema
            // 
            this.lblTituloProblema.AutoSize = true;
            this.lblTituloProblema.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProblema.ForeColor = System.Drawing.Color.Black;
            this.lblTituloProblema.Location = new System.Drawing.Point(19, 14);
            this.lblTituloProblema.Name = "lblTituloProblema";
            this.lblTituloProblema.Size = new System.Drawing.Size(118, 15);
            this.lblTituloProblema.TabIndex = 1;
            this.lblTituloProblema.Text = "Título del problema:";
            // 
            // txtTituloProblema
            // 
            this.txtTituloProblema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtTituloProblema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloProblema.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloProblema.Location = new System.Drawing.Point(22, 34);
            this.txtTituloProblema.Name = "txtTituloProblema";
            this.txtTituloProblema.Size = new System.Drawing.Size(150, 16);
            this.txtTituloProblema.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(214, 14);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 15);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(217, 32);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(140, 23);
            this.cmbCategoria.TabIndex = 4;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.ForeColor = System.Drawing.Color.Black;
            this.lblPrioridad.Location = new System.Drawing.Point(384, 14);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(62, 15);
            this.lblPrioridad.TabIndex = 5;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(387, 32);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(140, 23);
            this.cmbPrioridad.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 76);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 15);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(22, 96);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(260, 40);
            this.txtDescripcion.TabIndex = 8;
            // 
            // lblCreadoPor
            // 
            this.lblCreadoPor.AutoSize = true;
            this.lblCreadoPor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreadoPor.ForeColor = System.Drawing.Color.Black;
            this.lblCreadoPor.Location = new System.Drawing.Point(19, 166);
            this.lblCreadoPor.Name = "lblCreadoPor";
            this.lblCreadoPor.Size = new System.Drawing.Size(73, 15);
            this.lblCreadoPor.TabIndex = 9;
            this.lblCreadoPor.Text = "Creado por:";
            // 
            // txtCreadoPor
            // 
            this.txtCreadoPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtCreadoPor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreadoPor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreadoPor.Location = new System.Drawing.Point(154, 165);
            this.txtCreadoPor.Name = "txtCreadoPor";
            this.txtCreadoPor.ReadOnly = true;
            this.txtCreadoPor.Size = new System.Drawing.Size(180, 16);
            this.txtCreadoPor.TabIndex = 10;
            // 
            // lblModificadoPor
            // 
            this.lblModificadoPor.AutoSize = true;
            this.lblModificadoPor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificadoPor.ForeColor = System.Drawing.Color.Black;
            this.lblModificadoPor.Location = new System.Drawing.Point(19, 198);
            this.lblModificadoPor.Name = "lblModificadoPor";
            this.lblModificadoPor.Size = new System.Drawing.Size(94, 15);
            this.lblModificadoPor.TabIndex = 11;
            this.lblModificadoPor.Text = "Modificado por:";
            // 
            // txtModificadoPor
            // 
            this.txtModificadoPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtModificadoPor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificadoPor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificadoPor.Location = new System.Drawing.Point(154, 197);
            this.txtModificadoPor.Name = "txtModificadoPor";
            this.txtModificadoPor.ReadOnly = true;
            this.txtModificadoPor.Size = new System.Drawing.Size(180, 16);
            this.txtModificadoPor.TabIndex = 12;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCreacion.Location = new System.Drawing.Point(19, 230);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(97, 15);
            this.lblFechaCreacion.TabIndex = 13;
            this.lblFechaCreacion.Text = "Fecha creación:";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaCreacion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCreacion.Location = new System.Drawing.Point(154, 229);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(180, 16);
            this.txtFechaCreacion.TabIndex = 14;
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaModificacion.Location = new System.Drawing.Point(19, 262);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(119, 15);
            this.lblFechaModificacion.TabIndex = 15;
            this.lblFechaModificacion.Text = "Fecha Modificación:";
            // 
            // txtFechaModificacion
            // 
            this.txtFechaModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtFechaModificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaModificacion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaModificacion.Location = new System.Drawing.Point(154, 261);
            this.txtFechaModificacion.Name = "txtFechaModificacion";
            this.txtFechaModificacion.ReadOnly = true;
            this.txtFechaModificacion.Size = new System.Drawing.Size(180, 16);
            this.txtFechaModificacion.TabIndex = 16;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(19, 321);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(104, 15);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "Usuario:TECNICO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(544, 311);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 36);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(664, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 36);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.txtFechaModificacion);
            this.panel1.Controls.Add(this.lblFechaModificacion);
            this.panel1.Controls.Add(this.txtFechaCreacion);
            this.panel1.Controls.Add(this.lblFechaCreacion);
            this.panel1.Controls.Add(this.txtModificadoPor);
            this.panel1.Controls.Add(this.lblModificadoPor);
            this.panel1.Controls.Add(this.txtCreadoPor);
            this.panel1.Controls.Add(this.lblCreadoPor);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.cmbPrioridad);
            this.panel1.Controls.Add(this.lblPrioridad);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.txtTituloProblema);
            this.panel1.Controls.Add(this.lblTituloProblema);
            this.panel1.Location = new System.Drawing.Point(16, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 365);
            this.panel1.TabIndex = 20;
            // 
            // InformacionAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(820, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformacionAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpDesk - Información de Auditoría";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloProblema;
        private System.Windows.Forms.TextBox txtTituloProblema;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCreadoPor;
        private System.Windows.Forms.TextBox txtCreadoPor;
        private System.Windows.Forms.Label lblModificadoPor;
        private System.Windows.Forms.TextBox txtModificadoPor;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.TextBox txtFechaModificacion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
    }
}