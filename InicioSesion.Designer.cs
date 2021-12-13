
namespace Library
{
    partial class FInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicioSesion));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.llblOlvCont = new System.Windows.Forms.LinkLabel();
            this.btnRegresarMP = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAbrirCatalogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUser.Location = new System.Drawing.Point(76, 172);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 18);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPass.Location = new System.Drawing.Point(76, 213);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 18);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Black;
            this.btnIngresar.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIngresar.ForeColor = System.Drawing.Color.DimGray;
            this.btnIngresar.Location = new System.Drawing.Point(356, 325);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(112, 32);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(234, 170);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(377, 26);
            this.txtUser.TabIndex = 3;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(234, 204);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(377, 26);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // llblOlvCont
            // 
            this.llblOlvCont.AutoSize = true;
            this.llblOlvCont.BackColor = System.Drawing.Color.Transparent;
            this.llblOlvCont.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Italic);
            this.llblOlvCont.Location = new System.Drawing.Point(328, 259);
            this.llblOlvCont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblOlvCont.Name = "llblOlvCont";
            this.llblOlvCont.Size = new System.Drawing.Size(171, 16);
            this.llblOlvCont.TabIndex = 5;
            this.llblOlvCont.TabStop = true;
            this.llblOlvCont.Text = "¿Olvidaste la contraseña?";
            this.llblOlvCont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblOlvCont_LinkClicked);
            // 
            // btnRegresarMP
            // 
            this.btnRegresarMP.BackColor = System.Drawing.Color.Black;
            this.btnRegresarMP.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRegresarMP.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegresarMP.Location = new System.Drawing.Point(11, 413);
            this.btnRegresarMP.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarMP.Name = "btnRegresarMP";
            this.btnRegresarMP.Size = new System.Drawing.Size(134, 32);
            this.btnRegresarMP.TabIndex = 6;
            this.btnRegresarMP.Text = "Menú principal";
            this.btnRegresarMP.UseVisualStyleBackColor = false;
            this.btnRegresarMP.Click += new System.EventHandler(this.btnRegresarMP_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(13, 579);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAbrirCatalogo
            // 
            this.btnAbrirCatalogo.BackColor = System.Drawing.Color.Black;
            this.btnAbrirCatalogo.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAbrirCatalogo.ForeColor = System.Drawing.Color.DimGray;
            this.btnAbrirCatalogo.Location = new System.Drawing.Point(607, 394);
            this.btnAbrirCatalogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirCatalogo.Name = "btnAbrirCatalogo";
            this.btnAbrirCatalogo.Size = new System.Drawing.Size(180, 48);
            this.btnAbrirCatalogo.TabIndex = 7;
            this.btnAbrirCatalogo.Text = "Ir al catálogo sin iniciar sesión";
            this.btnAbrirCatalogo.UseVisualStyleBackColor = false;
            this.btnAbrirCatalogo.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAbrirCatalogo);
            this.Controls.Add(this.btnRegresarMP);
            this.Controls.Add(this.llblOlvCont);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FInicioSesion";
            this.Text = "Inicio de sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel llblOlvCont;
        private System.Windows.Forms.Button btnRegresarMP;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAbrirCatalogo;
    }
}