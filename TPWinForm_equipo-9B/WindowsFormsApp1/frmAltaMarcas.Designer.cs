namespace WindowsFormsApp1
{
    partial class frmAltaMarcas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreMarcas = new System.Windows.Forms.TextBox();
            this.btn_AceptarMarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // txtNombreMarcas
            // 
            this.txtNombreMarcas.Location = new System.Drawing.Point(182, 46);
            this.txtNombreMarcas.Name = "txtNombreMarcas";
            this.txtNombreMarcas.Size = new System.Drawing.Size(189, 22);
            this.txtNombreMarcas.TabIndex = 1;
            // 
            // btn_AceptarMarcas
            // 
            this.btn_AceptarMarcas.Location = new System.Drawing.Point(194, 98);
            this.btn_AceptarMarcas.Name = "btn_AceptarMarcas";
            this.btn_AceptarMarcas.Size = new System.Drawing.Size(77, 23);
            this.btn_AceptarMarcas.TabIndex = 2;
            this.btn_AceptarMarcas.Text = "Aceptar";
            this.btn_AceptarMarcas.UseVisualStyleBackColor = true;
            this.btn_AceptarMarcas.Click += new System.EventHandler(this.btn_AceptarMarcas_Click);
            // 
            // frmAltaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 133);
            this.Controls.Add(this.btn_AceptarMarcas);
            this.Controls.Add(this.txtNombreMarcas);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaMarcas";
            this.Text = "Alta de Marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreMarcas;
        private System.Windows.Forms.Button btn_AceptarMarcas;
    }
}