using System;
using System.Collections;
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
    public partial class FInicioSesion : Form
    {        
        public FInicioSesion()
        {
            InitializeComponent();
        }
        //Validar campos
        //Implementación de los métodos isnumber e isletter /Propiedad handled/booleans/KeyChar propiedad del evento KeyPressEvent 
        public void validarTxt(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        //Implementación de los métodos isnumber e isletter /Propiedad handled/booleans/KeyChar propiedad del evento KeyPressEvent 
        public void validarNum(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        //Método de tipo boolean validación vacíos
        public Boolean validarVacios()
        {
            bool res = true;

            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Ingresa los datos requeridos.", "Validación datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }
        //Código
        //Acción clic método de tipo void/Referencia de objeto sender (Captación del evento)/Clase que contiene los eventos EventArgs
        private void btnSalir_Click(object sender, EventArgs e)
        {   //Confirmar salida
            if (MessageBox.Show("¿Desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Acción clic
        private void btnRegresarMP_Click(object sender, EventArgs e)
        {   //Llamada a la ventana menú principal y cierra ventana inicio de sesión
            Form formLibraryMP = new FLibrary();
            formLibraryMP.Show();            
            this.Close();
        }
        //Acción clic
        private void btnAtras_Click(object sender, EventArgs e)
        {   //Muestra ventana menú y cierra ventana inicio de sesión
            Form formMenu = new FMenu();
            formMenu.Show();            
            this.Close();
        }   
        //Evento KeyPress
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {            
            validarTxt(sender, e);            
        }
        //LinkClic
        private void llblOlvCont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            MessageBox.Show("Revisa tu e-mail.","Recuperación contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //Método login
        public void datosLogAL()
        {       
            //Instancia arrayl
            ArrayList Credenciales = new ArrayList();
            ISesion sesion1 = new ISesion();
            ISesion sesion2 = new ISesion();

            //Datos inicio de sesión guardados en un ArrayList
            sesion1.User = "Mafe";
            sesion1.Pass = "9707";
            Credenciales.Add(sesion1);
            sesion2.User = "Cristofer";
            sesion2.Pass = "9705";
            Credenciales.Add(sesion2);

            //Condicionales ingresar al login
            if (txtUser.Text.Contains(sesion1.User) && txtPass.Text.Contains(sesion1.Pass))
            {
                Form formMenu = new FMenu();
                formMenu.Show();                
                this.Close();
                MessageBox.Show("Recuerda " + (sesion1.User) + " que estamos en mantenimiento, en caso de dudas visita nuestra sede más cercana.", "Bienvenida");
            }
            else if (txtUser.Text.Contains(sesion2.User) && txtPass.Text.Contains(sesion2.Pass))
            {
                Form formMenu = new FMenu();
                formMenu.Show();
                this.Close();
                MessageBox.Show("Recuerda " + (sesion2.User) + " que estamos en mantenimiento, en caso de dudas visita nuestra sede más cercana.", "Bienvenido");
            }
            else if (txtUser.Text != (sesion1.User) && txtUser.Text != "" && txtPass.Text != (sesion1.Pass) && txtPass.Text != "")
            {
                MessageBox.Show("Verifica usuario y/o contraseña.", "Credenciales");
            }
            else if (txtUser.Text != (sesion2.User) && txtUser.Text != "" && txtPass.Text != (sesion2.Pass) && txtPass.Text != "")
            {
                MessageBox.Show("Verifica usuario y/o contraseña.", "Credenciales");
            }
            else 
            {   //Método de validación al ingresar
                validarVacios();
            }
           

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {          
            datosLogAL();           
        }

        
    }
}
