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
    public partial class FRegistro : Form
    {
        public FRegistro()
        {
            InitializeComponent();
        }
        //Validación campos
        private void validarCampo()
        {
            //Condicional validación campos con el control errorprovider
            if (txtNombreUser.Text == "")
            {
                //Asignando el tipo de error con el método SetError
                errorProvider1.SetError(txtNombreUser, "Debe ingresar un nombre de usuario para continuar con el registro.");
                txtNombreUser.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreUser, "");
            if (txtContrasenia.Text == "")
            {
                //Asignando el tipo de error con el método SetError
                errorProvider1.SetError(txtContrasenia, "Debe ingresar una contraseña continuar con el registro.");
                txtContrasenia.Focus();
                return;
            }
            errorProvider1.SetError(txtContrasenia, "");
            if (txtCContrasenia.Text == "")
            {
                //Asignando el tipo de error con el método SetError
                errorProvider1.SetError(txtCContrasenia, "Debe confirmar la contraseña para continuar con el registro.");
                txtCContrasenia.Focus();
                return;
            }
            errorProvider1.SetError(txtCContrasenia, "");
            if (cbxTerminos.Checked == false)
            {
                errorProvider1.SetError(cbxTerminos, "Debe seleccionar para continuar.");
                return;
            }
            
            //Validación coincidencia campos
            if (txtContrasenia.Text != txtCContrasenia.Text)
            {
                MessageBox.Show("Las contraseñas deben de coincidir.", "Validar contraseña");
            }
        }
        //Salir de la app
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Regresar al menú
        private void btnMenuP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea abandonar la página? Perderá los cambios realizados.", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form formLibraryMP = new FLibrary();
                formLibraryMP.Show();
                this.Close();
            }            
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            validarCampo();
            MessageBox.Show("Actualmente nos encontramos en mantenimiento. Inténtalo más tarde", "Información mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Question);
            
        }
    }
}
