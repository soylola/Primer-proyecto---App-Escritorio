namespace MiPrimerAplicacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.LinkLabel();
            this.btnBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 9.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(326, 356);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Etiqueta";
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // txtTexto2
            // 
            this.txtTexto2.Location = new System.Drawing.Point(484, 423);
            this.txtTexto2.Multiline = true;
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto2.Size = new System.Drawing.Size(244, 26);
            this.txtTexto2.TabIndex = 4;
            this.txtTexto2.Leave += new System.EventHandler(this.txtTexto2_Leave);
            // 
            // txtTexto
            // 
            this.txtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTexto.Location = new System.Drawing.Point(484, 356);
            this.txtTexto.MaxLength = 30;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(244, 47);
            this.txtTexto.TabIndex = 3;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // lblImagen
            // 
            this.lblImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblImagen.Location = new System.Drawing.Point(480, 270);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(161, 39);
            this.lblImagen.TabIndex = 0;
            this.lblImagen.TabStop = true;
            this.lblImagen.Text = "Ver imagen";
            this.lblImagen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblImagen_LinkClicked);
            // 
            // btnBoton
            // 
            this.btnBoton.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoton.Image = global::MiPrimerAplicacion.Properties.Resources.WhatsApp_Image_2023_09_12_at_21_03_56;
            this.btnBoton.Location = new System.Drawing.Point(388, 166);
            this.btnBoton.Margin = new System.Windows.Forms.Padding(6);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(173, 76);
            this.btnBoton.TabIndex = 1;
            this.btnBoton.Text = "Botón";
            this.btnBoton.UseVisualStyleBackColor = false;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1124, 631);
            this.Controls.Add(this.txtTexto2);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoton);
            this.Controls.Add(this.lblImagen);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiPrimerAplicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Click += new System.EventHandler(this.frmPrincipal_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.LinkLabel lblImagen;
        private System.Windows.Forms.Button btnBoton;
    }
}

