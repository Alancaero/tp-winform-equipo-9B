namespace WindowsFormsApp1
{
    partial class frmAltaCategoria
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
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btn_AceptarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(156, 48);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(189, 22);
            this.txtNombreCategoria.TabIndex = 1;
            // 
            // btn_AceptarCategoria
            // 
            this.btn_AceptarCategoria.Location = new System.Drawing.Point(205, 91);
            this.btn_AceptarCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AceptarCategoria.Name = "btn_AceptarCategoria";
            this.btn_AceptarCategoria.Size = new System.Drawing.Size(77, 27);
            this.btn_AceptarCategoria.TabIndex = 2;
            this.btn_AceptarCategoria.Text = "Aceptar";
            this.btn_AceptarCategoria.UseVisualStyleBackColor = true;
            this.btn_AceptarCategoria.Click += new System.EventHandler(this.btn_AceptarCategoria_Click);
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 133);
            this.Controls.Add(this.btn_AceptarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAltaCategoria";
            this.Text = "Alta de Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btn_AceptarCategoria;
    }
}