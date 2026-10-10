namespace Fundamentos_tf_v1.Forms
{
    partial class DashboardGeneral
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMisTickets = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTarjetaTickets = new System.Windows.Forms.DataGridView();
            this.btnTicketsRegistrados = new System.Windows.Forms.Button();
            this.btnTicketsEvaluacion = new System.Windows.Forms.Button();
            this.btnTicketsResueltos = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetaTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.lblUsuario);
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Controls.Add(this.btnReportes);
            this.pnlSidebar.Controls.Add(this.label1);
            this.pnlSidebar.Controls.Add(this.btnMisTickets);
            this.pnlSidebar.Controls.Add(this.btnInicio);
            this.pnlSidebar.Location = new System.Drawing.Point(14, 16);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(158, 419);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(14, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(42, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportes.Location = new System.Drawing.Point(17, 141);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(126, 23);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HelpDesk";
            // 
            // btnMisTickets
            // 
            this.btnMisTickets.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMisTickets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMisTickets.Location = new System.Drawing.Point(17, 112);
            this.btnMisTickets.Name = "btnMisTickets";
            this.btnMisTickets.Size = new System.Drawing.Size(126, 23);
            this.btnMisTickets.TabIndex = 4;
            this.btnMisTickets.Text = "Mis Tickets";
            this.btnMisTickets.UseVisualStyleBackColor = false;
            this.btnMisTickets.Click += new System.EventHandler(this.btnMisTickets_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicio.Location = new System.Drawing.Point(17, 83);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(126, 23);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(193, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dashboard";
            // 
            // dgvTarjetaTickets
            // 
            this.dgvTarjetaTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetaTickets.Location = new System.Drawing.Point(192, 211);
            this.dgvTarjetaTickets.Name = "dgvTarjetaTickets";
            this.dgvTarjetaTickets.Size = new System.Drawing.Size(593, 223);
            this.dgvTarjetaTickets.TabIndex = 2;
            // 
            // btnTicketsRegistrados
            // 
            this.btnTicketsRegistrados.BackColor = System.Drawing.Color.Pink;
            this.btnTicketsRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsRegistrados.Location = new System.Drawing.Point(199, 108);
            this.btnTicketsRegistrados.Name = "btnTicketsRegistrados";
            this.btnTicketsRegistrados.Size = new System.Drawing.Size(171, 54);
            this.btnTicketsRegistrados.TabIndex = 3;
            this.btnTicketsRegistrados.Text = "Tickets Registrados";
            this.btnTicketsRegistrados.UseVisualStyleBackColor = false;
            this.btnTicketsRegistrados.Click += new System.EventHandler(this.btnTicketsRegistrados_Click);
            // 
            // btnTicketsEvaluacion
            // 
            this.btnTicketsEvaluacion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnTicketsEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsEvaluacion.Location = new System.Drawing.Point(406, 108);
            this.btnTicketsEvaluacion.Name = "btnTicketsEvaluacion";
            this.btnTicketsEvaluacion.Size = new System.Drawing.Size(171, 55);
            this.btnTicketsEvaluacion.TabIndex = 4;
            this.btnTicketsEvaluacion.Text = "Tickets en Evaluacion";
            this.btnTicketsEvaluacion.UseVisualStyleBackColor = false;
            this.btnTicketsEvaluacion.Click += new System.EventHandler(this.btnTicketsEvaluacion_Click);
            // 
            // btnTicketsResueltos
            // 
            this.btnTicketsResueltos.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTicketsResueltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsResueltos.Location = new System.Drawing.Point(614, 106);
            this.btnTicketsResueltos.Name = "btnTicketsResueltos";
            this.btnTicketsResueltos.Size = new System.Drawing.Size(171, 59);
            this.btnTicketsResueltos.TabIndex = 5;
            this.btnTicketsResueltos.Text = "Tickets Resueltos";
            this.btnTicketsResueltos.UseVisualStyleBackColor = false;
            this.btnTicketsResueltos.Click += new System.EventHandler(this.btnTicketsResueltos_Click);
            // 
            // DashboardGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTicketsResueltos);
            this.Controls.Add(this.btnTicketsEvaluacion);
            this.Controls.Add(this.btnTicketsRegistrados);
            this.Controls.Add(this.dgvTarjetaTickets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "DashboardGeneral";
            this.Text = "DashboardGeneral";
            this.Load += new System.EventHandler(this.DashboardGeneral_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetaTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMisTickets;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTarjetaTickets;
        private System.Windows.Forms.Button btnTicketsRegistrados;
        private System.Windows.Forms.Button btnTicketsEvaluacion;
        private System.Windows.Forms.Button btnTicketsResueltos;
    }
}