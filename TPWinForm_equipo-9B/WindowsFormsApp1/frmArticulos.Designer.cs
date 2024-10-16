namespace WindowsFormsApp1
{
    partial class frmArticulos
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
            this.lblArticulo = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminarFisico = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.btn_GestionarCategorias = new System.Windows.Forms.Button();
            this.btn_GestionarMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(496, 11);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(149, 29);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "ARTICULOS";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AccessibleName = "dgvArticulos";
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(4, 111);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(823, 353);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(847, 111);
            this.pbxArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(299, 353);
            this.pbxArticulos.TabIndex = 2;
            this.pbxArticulos.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(16, 471);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 39);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(164, 471);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(100, 39);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminarFisico
            // 
            this.buttonEliminarFisico.Location = new System.Drawing.Point(313, 471);
            this.buttonEliminarFisico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEliminarFisico.Name = "buttonEliminarFisico";
            this.buttonEliminarFisico.Size = new System.Drawing.Size(149, 39);
            this.buttonEliminarFisico.TabIndex = 5;
            this.buttonEliminarFisico.Text = "Eliminación Física";
            this.buttonEliminarFisico.UseVisualStyleBackColor = true;
            this.buttonEliminarFisico.Click += new System.EventHandler(this.buttonEliminarFisico_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(32, 534);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 6;
            this.lblCampo.Text = "Campo";
            // 
            // cbxCampo
            // 
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(128, 530);
            this.cbxCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(160, 24);
            this.cbxCampo.TabIndex = 7;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(373, 534);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 8;
            this.lblCriterio.Text = "Criterio";
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(456, 530);
            this.cbxCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(160, 24);
            this.cbxCriterio.TabIndex = 9;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 73);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(87, 16);
            this.lblFiltro.TabIndex = 10;
            this.lblFiltro.Text = "Filtro Rápido:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(128, 64);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(245, 22);
            this.txtFiltro.TabIndex = 11;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtro";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(755, 528);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(132, 22);
            this.txtFiltroAvanzado.TabIndex = 15;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(949, 523);
            this.button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 16;
            this.button.Text = "Buscar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_GestionarCategorias
            // 
            this.btn_GestionarCategorias.Location = new System.Drawing.Point(501, 471);
            this.btn_GestionarCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GestionarCategorias.Name = "btn_GestionarCategorias";
            this.btn_GestionarCategorias.Size = new System.Drawing.Size(161, 39);
            this.btn_GestionarCategorias.TabIndex = 17;
            this.btn_GestionarCategorias.Text = "Gestionar Categorias";
            this.btn_GestionarCategorias.UseVisualStyleBackColor = true;
            this.btn_GestionarCategorias.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_GestionarMarcas
            // 
            this.btn_GestionarMarcas.Location = new System.Drawing.Point(702, 479);
            this.btn_GestionarMarcas.Name = "btn_GestionarMarcas";
            this.btn_GestionarMarcas.Size = new System.Drawing.Size(151, 31);
            this.btn_GestionarMarcas.TabIndex = 18;
            this.btn_GestionarMarcas.Text = "Gestionar Marcas";
            this.btn_GestionarMarcas.UseVisualStyleBackColor = true;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 556);
            this.Controls.Add(this.btn_GestionarMarcas);
            this.Controls.Add(this.btn_GestionarCategorias);
            this.Controls.Add(this.button);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.buttonEliminarFisico);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblArticulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1189, 603);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1189, 603);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminarFisico;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button btn_GestionarCategorias;
        private System.Windows.Forms.Button btn_GestionarMarcas;
    }
}

