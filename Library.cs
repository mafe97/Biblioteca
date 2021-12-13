using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FLibrary : Form
    {
        public FLibrary()
        {
            InitializeComponent();
        }
        //Evento clic confirmación de salida
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Evento clic ayuda al usuario
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mensaje informativo
            MessageBox.Show("Dirígete a la sede más cerca o contáctanos por medio de nuestras líneas de atención al cliente.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //Evento clic para registrarse
        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form formRegistro = new FRegistro();
            formRegistro.Show();
            this.Hide();
        }
        //Evento clic para inicio de sesión
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Llamada a la ventada de inicio de s y cierra ventana menú principal
            Form formInicioS = new FInicioSesion();            
            formInicioS.Show();
            this.Hide();
            
        }
    }
}
