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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }
        //Evento clic
        private void búsquedaDeEjemplaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir y ocultar formularios
            Form formBusqueda = new FBusqueda();
            formBusqueda.Show();
            this.Hide();
        }
        //Evento clic
        private void búsquedaDeEjemplaresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Mensaje informativo
            MessageBox.Show("Actualmente nuestra área de venta de libros se encuentra en mantenimiento, para mayor información comunicate con nuestra línea de atención al cliente.", "Venta de libros", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
        //Evento clic
        private void regresarAlMenúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir y ocultar formularios
            Form formLibraryMP = new FLibrary();
            formLibraryMP.Show();
            this.Hide();
        }
    }
}
