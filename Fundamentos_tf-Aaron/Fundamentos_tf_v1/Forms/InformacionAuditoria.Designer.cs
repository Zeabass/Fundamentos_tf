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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCreadoPor = new System.Windows.Forms.Label();
            this.lblModificadoPor = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.lblModifiedAt = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblModifiedBy = new System.Windows.Forms.Label();
            this.cmbBuscarTicket = new System.Windows.Forms.ComboBox();
            this.txtLabel1 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
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
            this.lblTituloProblema.Location = new System.Drawing.Point(277, 76);
            this.lblTituloProblema.Name = "lblTituloProblema";
            this.lblTituloProblema.Size = new System.Drawing.Size(118, 15);
            this.lblTituloProblema.TabIndex = 1;
            this.lblTituloProblema.Text = "Título del problema:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(280, 96);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(150, 16);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(462, 76);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 15);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 140);
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
            this.txtDescripcion.Location = new System.Drawing.Point(38, 160);
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
            this.lblCreadoPor.Location = new System.Drawing.Point(35, 230);
            this.lblCreadoPor.Name = "lblCreadoPor";
            this.lblCreadoPor.Size = new System.Drawing.Size(73, 15);
            this.lblCreadoPor.TabIndex = 9;
            this.lblCreadoPor.Text = "Creado por:";
            // 
            // lblModificadoPor
            // 
            this.lblModificadoPor.AutoSize = true;
            this.lblModificadoPor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificadoPor.ForeColor = System.Drawing.Color.Black;
            this.lblModificadoPor.Location = new System.Drawing.Point(35, 262);
            this.lblModificadoPor.Name = "lblModificadoPor";
            this.lblModificadoPor.Size = new System.Drawing.Size(94, 15);
            this.lblModificadoPor.TabIndex = 11;
            this.lblModificadoPor.Text = "Modificado por:";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCreacion.Location = new System.Drawing.Point(35, 294);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(97, 15);
            this.lblFechaCreacion.TabIndex = 13;
            this.lblFechaCreacion.Text = "Fecha creación:";
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaModificacion.Location = new System.Drawing.Point(35, 326);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(119, 15);
            this.lblFechaModificacion.TabIndex = 15;
            this.lblFechaModificacion.Text = "Fecha Modificación:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(35, 385);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 15);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(645, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 36);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.AutoSize = true;
            this.lblCreateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCreateBy.Location = new System.Drawing.Point(177, 230);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(11, 15);
            this.lblCreateBy.TabIndex = 20;
            this.lblCreateBy.Text = "-";
            // 
            // lblModifiedAt
            // 
            this.lblModifiedAt.AutoSize = true;
            this.lblModifiedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblModifiedAt.Location = new System.Drawing.Point(177, 322);
            this.lblModifiedAt.Name = "lblModifiedAt";
            this.lblModifiedAt.Size = new System.Drawing.Size(11, 15);
            this.lblModifiedAt.TabIndex = 23;
            this.lblModifiedAt.Text = "-";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCreatedAt.Location = new System.Drawing.Point(177, 292);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(11, 15);
            this.lblCreatedAt.TabIndex = 22;
            this.lblCreatedAt.Text = "-";
            // 
            // lblModifiedBy
            // 
            this.lblModifiedBy.AutoSize = true;
            this.lblModifiedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblModifiedBy.Location = new System.Drawing.Point(177, 262);
            this.lblModifiedBy.Name = "lblModifiedBy";
            this.lblModifiedBy.Size = new System.Drawing.Size(11, 15);
            this.lblModifiedBy.TabIndex = 21;
            this.lblModifiedBy.Text = "-";
            // 
            // cmbBuscarTicket
            // 
            this.cmbBuscarTicket.FormattingEnabled = true;
            this.cmbBuscarTicket.Location = new System.Drawing.Point(38, 96);
            this.cmbBuscarTicket.Name = "cmbBuscarTicket";
            this.cmbBuscarTicket.Size = new System.Drawing.Size(150, 21);
            this.cmbBuscarTicket.TabIndex = 24;
            this.cmbBuscarTicket.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarTicket_SelectedIndexChanged);
            // 
            // txtLabel1
            // 
            this.txtLabel1.AutoSize = true;
            this.txtLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel1.ForeColor = System.Drawing.Color.Black;
            this.txtLabel1.Location = new System.Drawing.Point(36, 76);
            this.txtLabel1.Name = "txtLabel1";
            this.txtLabel1.Size = new System.Drawing.Size(86, 15);
            this.txtLabel1.TabIndex = 25;
            this.txtLabel1.Text = "BuscarTicket:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(465, 97);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(150, 16);
            this.txtCategoria.TabIndex = 26;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.ForeColor = System.Drawing.Color.Black;
            this.lblPrioridad.Location = new System.Drawing.Point(642, 76);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(62, 15);
            this.lblPrioridad.TabIndex = 5;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtPrioridad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrioridad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrioridad.Location = new System.Drawing.Point(645, 97);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.ReadOnly = true;
            this.txtPrioridad.Size = new System.Drawing.Size(150, 16);
            this.txtPrioridad.TabIndex = 27;
            // 
            // InformacionAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 435);
            this.Controls.Add(this.txtPrioridad);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtLabel1);
            this.Controls.Add(this.cmbBuscarTicket);
            this.Controls.Add(this.lblModifiedAt);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblModifiedBy);
            this.Controls.Add(this.lblCreateBy);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFechaModificacion);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblModificadoPor);
            this.Controls.Add(this.lblCreadoPor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTituloProblema);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformacionAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpDesk - Información de Auditoría";
            this.Load += new System.EventHandler(this.InformacionAuditoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloProblema;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCreadoPor;
        private System.Windows.Forms.Label lblModificadoPor;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.Label lblModifiedAt;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblModifiedBy;
        private System.Windows.Forms.ComboBox cmbBuscarTicket;
        private System.Windows.Forms.Label txtLabel1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.TextBox txtPrioridad;
    }
}