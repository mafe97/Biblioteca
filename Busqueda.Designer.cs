
namespace Library
{
    partial class FBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBusqueda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxEBusqueda = new System.Windows.Forms.GroupBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxRBusqueda = new System.Windows.Forms.GroupBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.lblEjEncontrados = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevaB = new System.Windows.Forms.Button();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxEBusqueda.SuspendLayout();
            this.gbxRBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxEBusqueda
            // 
            this.gbxEBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbxEBusqueda.BackgroundImage")));
            this.gbxEBusqueda.Controls.Add(this.lblAutor);
            this.gbxEBusqueda.Controls.Add(this.lblLibro);
            this.gbxEBusqueda.Controls.Add(this.txtAutor);
            this.gbxEBusqueda.Controls.Add(this.txtLibro);
            this.gbxEBusqueda.Controls.Add(this.btnBuscar2);
            this.gbxEBusqueda.Controls.Add(this.btnBuscar1);
            this.gbxEBusqueda.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbxEBusqueda.Location = new System.Drawing.Point(24, 13);
            this.gbxEBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEBusqueda.Name = "gbxEBusqueda";
            this.gbxEBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEBusqueda.Size = new System.Drawing.Size(721, 164);
            this.gbxEBusqueda.TabIndex = 0;
            this.gbxEBusqueda.TabStop = false;
            this.gbxEBusqueda.Text = "Explorador de búsqueda";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Location = new System.Drawing.Point(79, 114);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(54, 18);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.BackColor = System.Drawing.Color.Transparent;
            this.lblLibro.Location = new System.Drawing.Point(79, 46);
            this.lblLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(50, 18);
            this.lblLibro.TabIndex = 4;
            this.lblLibro.Text = "Libro";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(167, 107);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(359, 26);
            this.txtAutor.TabIndex = 3;
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(167, 40);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(359, 26);
            this.txtLibro.TabIndex = 2;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBuscar2.Location = new System.Drawing.Point(611, 106);
            this.btnBuscar2.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar2.TabIndex = 1;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBuscar1.Location = new System.Drawing.Point(611, 39);
            this.btnBuscar1.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(88, 26);
            this.btnBuscar1.TabIndex = 0;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // gbxRBusqueda
            // 
            this.gbxRBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbxRBusqueda.BackgroundImage")));
            this.gbxRBusqueda.Controls.Add(this.dgvLibros);
            this.gbxRBusqueda.Controls.Add(this.lblEjEncontrados);
            this.gbxRBusqueda.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbxRBusqueda.Location = new System.Drawing.Point(24, 185);
            this.gbxRBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.gbxRBusqueda.Name = "gbxRBusqueda";
            this.gbxRBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.gbxRBusqueda.Size = new System.Drawing.Size(721, 197);
            this.gbxRBusqueda.TabIndex = 1;
            this.gbxRBusqueda.TabStop = false;
            this.gbxRBusqueda.Text = "Resultado de búsqueda realizada";
            // 
            // dgvLibros
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libro,
            this.Autor,
            this.Ubicacion,
            this.Disponibilidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLibros.GridColor = System.Drawing.Color.DarkGray;
            this.dgvLibros.Location = new System.Drawing.Point(7, 45);
            this.dgvLibros.Name = "dgvLibros";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            this.dgvLibros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLibros.Size = new System.Drawing.Size(707, 132);
            this.dgvLibros.TabIndex = 3;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellContentClick);
            // 
            // lblEjEncontrados
            // 
            this.lblEjEncontrados.AutoSize = true;
            this.lblEjEncontrados.BackColor = System.Drawing.Color.Transparent;
            this.lblEjEncontrados.Location = new System.Drawing.Point(261, 24);
            this.lblEjEncontrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEjEncontrados.Name = "lblEjEncontrados";
            this.lblEjEncontrados.Size = new System.Drawing.Size(201, 18);
            this.lblEjEncontrados.TabIndex = 0;
            this.lblEjEncontrados.Text = "Ejemplares encontrados";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSalir.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalir.Location = new System.Drawing.Point(9, 414);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevaB
            // 
            this.btnNuevaB.BackColor = System.Drawing.Color.Black;
            this.btnNuevaB.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNuevaB.ForeColor = System.Drawing.Color.DimGray;
            this.btnNuevaB.Location = new System.Drawing.Point(659, 390);
            this.btnNuevaB.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaB.Name = "btnNuevaB";
            this.btnNuevaB.Size = new System.Drawing.Size(128, 54);
            this.btnNuevaB.TabIndex = 7;
            this.btnNuevaB.Text = "Nueva búsqueda";
            this.btnNuevaB.UseVisualStyleBackColor = false;
            this.btnNuevaB.Click += new System.EventHandler(this.btnNuevaB_Click);
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.Width = 160;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.Width = 162;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicación";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Width = 200;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.HeaderText = "Disponibilidad";
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.Width = 150;
            // 
            // FBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevaB);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxRBusqueda);
            this.Controls.Add(this.gbxEBusqueda);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FBusqueda";
            this.Text = "Búsqueda";
            this.Load += new System.EventHandler(this.FBusqueda_Load);
            this.gbxEBusqueda.ResumeLayout(false);
            this.gbxEBusqueda.PerformLayout();
            this.gbxRBusqueda.ResumeLayout(false);
            this.gbxRBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEBusqueda;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button btnBuscar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxRBusqueda;
        private System.Windows.Forms.Label lblEjEncontrados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevaB;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
    }
}