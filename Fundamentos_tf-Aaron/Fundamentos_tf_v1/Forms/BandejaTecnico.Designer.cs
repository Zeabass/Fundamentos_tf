namespace Fundamentos_tf_v1.Forms
{
    partial class BandejaTecnico
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dgvTicketsPendientes = new System.Windows.Forms.DataGridView();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAtenderCaso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketsPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUsuario.Location = new System.Drawing.Point(20, 58);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(77, 22);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // dgvTicketsPendientes
            // 
            this.dgvTicketsPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketsPendientes.Location = new System.Drawing.Point(24, 108);
            this.dgvTicketsPendientes.Name = "dgvTicketsPendientes";
            this.dgvTicketsPendientes.Size = new System.Drawing.Size(742, 276);
            this.dgvTicketsPendientes.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(655, 399);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(111, 30);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAtenderCaso
            // 
            this.btnAtenderCaso.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtenderCaso.Location = new System.Drawing.Point(520, 399);
            this.btnAtenderCaso.Name = "btnAtenderCaso";
            this.btnAtenderCaso.Size = new System.Drawing.Size(111, 30);
            this.btnAtenderCaso.TabIndex = 3;
            this.btnAtenderCaso.Text = "Atender Caso";
            this.btnAtenderCaso.UseVisualStyleBackColor = false;
            this.btnAtenderCaso.Click += new System.EventHandler(this.btnAtenderCaso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tickets Asignados";
            // 
            // BandejaTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtenderCaso);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.dgvTicketsPendientes);
            this.Controls.Add(this.lblUsuario);
            this.Name = "BandejaTecnico";
            this.Text = "BandejaTecnico";
            this.Load += new System.EventHandler(this.BandejaTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketsPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dgvTicketsPendientes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAtenderCaso;
        private System.Windows.Forms.Label label1;
    }
}