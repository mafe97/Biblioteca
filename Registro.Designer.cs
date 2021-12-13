
namespace Library
{
    partial class FRegistro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegistro));
            this.lblComunidad = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblCContrasenia = new System.Windows.Forms.Label();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.txtCContrasenia = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenuP = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.cbxTerminos = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComunidad
            // 
            this.lblComunidad.AutoSize = true;
            this.lblComunidad.BackColor = System.Drawing.Color.Transparent;
            this.lblComunidad.Font = new System.Drawing.Font("Lucida Sans", 16.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblComunidad.ForeColor = System.Drawing.Color.White;
            this.lblComunidad.Location = new System.Drawing.Point(267, 19);
            this.lblComunidad.Name = "lblComunidad";
            this.lblComunidad.Size = new System.Drawing.Size(391, 25);
            this.lblComunidad.TabIndex = 0;
            this.lblComunidad.Text = "¡Haz parte de nuestra comunidad!";
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUser.ForeColor = System.Drawing.Color.White;
            this.lblNombreUser.Location = new System.Drawing.Point(155, 98);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(130, 17);
            this.lblNombreUser.TabIndex = 1;
            this.lblNombreUser.Text = "Nombre usuario";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.ForeColor = System.Drawing.Color.White;
            this.lblContrasenia.Location = new System.Drawing.Point(155, 155);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(95, 17);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblCContrasenia
            // 
            this.lblCContrasenia.AutoSize = true;
            this.lblCContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblCContrasenia.ForeColor = System.Drawing.Color.White;
            this.lblCContrasenia.Location = new System.Drawing.Point(155, 225);
            this.lblCContrasenia.Name = "lblCContrasenia";
            this.lblCContrasenia.Size = new System.Drawing.Size(198, 17);
            this.lblCContrasenia.TabIndex = 3;
            this.lblCContrasenia.Text = "Confirmación contraseña";
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Location = new System.Drawing.Point(362, 98);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(249, 25);
            this.txtNombreUser.TabIndex = 4;
            // 
            // txtCContrasenia
            // 
            this.txtCContrasenia.Location = new System.Drawing.Point(362, 217);
            this.txtCContrasenia.Name = "txtCContrasenia";
            this.txtCContrasenia.Size = new System.Drawing.Size(249, 25);
            this.txtCContrasenia.TabIndex = 5;
            this.txtCContrasenia.UseSystemPasswordChar = true;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(362, 155);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(249, 25);
            this.txtContrasenia.TabIndex = 6;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalir.Location = new System.Drawing.Point(9, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 38);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenuP
            // 
            this.btnMenuP.BackColor = System.Drawing.Color.Black;
            this.btnMenuP.ForeColor = System.Drawing.Color.DimGray;
            this.btnMenuP.Location = new System.Drawing.Point(660, 409);
            this.btnMenuP.Name = "btnMenuP";
            this.btnMenuP.Size = new System.Drawing.Size(130, 38);
            this.btnMenuP.TabIndex = 8;
            this.btnMenuP.Text = "Menú principal";
            this.btnMenuP.UseVisualStyleBackColor = false;
            this.btnMenuP.Click += new System.EventHandler(this.btnMenuP_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarse.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegistrarse.Location = new System.Drawing.Point(418, 299);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(109, 32);
            this.btnRegistrarse.TabIndex = 9;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // cbxTerminos
            // 
            this.cbxTerminos.AutoSize = true;
            this.cbxTerminos.BackColor = System.Drawing.Color.Transparent;
            this.cbxTerminos.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTerminos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbxTerminos.Location = new System.Drawing.Point(158, 282);
            this.cbxTerminos.Name = "cbxTerminos";
            this.cbxTerminos.Size = new System.Drawing.Size(207, 18);
            this.cbxTerminos.TabIndex = 10;
            this.cbxTerminos.Text = "Acepta términos y condiciones";
            this.cbxTerminos.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxTerminos);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnMenuP);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtCContrasenia);
            this.Controls.Add(this.txtNombreUser);
            this.Controls.Add(this.lblCContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNombreUser);
            this.Controls.Add(this.lblComunidad);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRegistro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComunidad;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblCContrasenia;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.TextBox txtCContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenuP;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.CheckBox cbxTerminos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}