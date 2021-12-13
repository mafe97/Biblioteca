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
    public partial class FBusqueda : Form
    {

        //ArrayList instancia 
        ArrayList Bibliotecas = new ArrayList();
        //Creación de objetos
        Biblioteca biblio1 = new Biblioteca();
        Biblioteca biblio2 = new Biblioteca();
        Biblioteca biblio3 = new Biblioteca();

        public FBusqueda()
        {
            InitializeComponent();
        }
        //Validar campos
        public void validarTxt(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        public void validarNum(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if(Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        public Boolean validarVacios()
        {
            bool res = true;

            if (txtLibro.Text == "" || txtAutor.Text == "")
            {
                MessageBox.Show("Ingresa el nombre del libro o el nombre del autor.", "Validación datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;            
        }
        //Des-habilita buttons    
        public void buttDesAct()
        {
            btnBuscar1.Enabled = false;
            btnBuscar2.Enabled = false;
        }
        public void buttActiv()
        {
            btnBuscar1.Enabled = true;
            btnBuscar2.Enabled = true;
        }
        //Código
        //Evento clic con validación para salir del programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Evento clic para realizar búsqueda
        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            buttDesAct();
            ALBibliotecas();
        }
        //Evento clic para realizar búsqueda
        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            buttDesAct();
            ALBibliotecas();            
        }
        //Limpiar txt y groupbox para realizar nueva búsqueda
        private void btnNuevaB_Click(object sender, EventArgs e)
        {
            foreach(Control bsqDatos in this.gbxEBusqueda.Controls)
            {
                if (bsqDatos is TextBox)
                    bsqDatos.Text = String.Empty;
                dgvLibros.Rows.Clear();
                buttActiv();                
            }
            txtLibro.Focus();            
        }
        //Formulario búsqueda evento load
        private void FBusqueda_Load(object sender, EventArgs e)
        {
            //Clase Biblioteca, objetos biblio1, 2, 3.
            biblio1.Libro = "Se busca una mujer";
            biblio1.Autor = "Charles Bukowski";
            biblio1.Ubicacion = "Literatura novelezca área 1.A";
            biblio1.Estado = "En préstamo";
            Bibliotecas.Add(biblio1); //Agrego objeto al arrayList

            biblio2.Libro = "Ortografia";
            biblio2.Autor = "Gonzalo Andres Muñoz";
            biblio2.Ubicacion = "Lengua española área 2.T";
            biblio2.Estado = "Disponible";
            Bibliotecas.Add(biblio2); //Agrego objeto al arrayList

            biblio3.Libro = "El festival de la blasfemia";
            biblio3.Autor = "Dross Rotzank";
            biblio3.Ubicacion = "Literatura Horror área 3.R";
            biblio3.Estado = "Disponible";
            Bibliotecas.Add(biblio3); //Agrego objeto al arrayList
            //dgvLibros.DataSource = Bibliotecas; //Mostrar datos en el dataGridV
        }
        private void ALBibliotecas()
        {
            int i;
            for (i = 0; i < 1; i++)
            {
                if (txtLibro.Text.Contains(biblio1.Libro) || txtAutor.Text.Contains(biblio1.Autor))
                {
                    dgvLibros.Rows.Add(biblio1.Libro, biblio1.Autor, biblio1.Ubicacion, biblio1.Estado);
                }
                else if (txtLibro.Text.Contains(biblio2.Libro) || txtAutor.Text.Contains(biblio2.Autor))
                {
                    dgvLibros.Rows.Add(biblio2.Libro, biblio2.Autor, biblio2.Ubicacion, biblio2.Estado);
                }
                else if (txtLibro.Text.Contains(biblio3.Libro) || txtAutor.Text.Contains(biblio3.Autor))
                {
                    dgvLibros.Rows.Add(biblio3.Libro, biblio3.Autor, biblio3.Ubicacion, biblio3.Estado);
                }
                else if (txtLibro.Text != (biblio1.Libro) && txtLibro.Text != "" || txtLibro.Text != (biblio2.Libro) && txtLibro.Text != "" || txtLibro.Text != (biblio3.Libro) && txtLibro.Text != "" || txtAutor.Text != (biblio1.Autor) && txtAutor.Text != "" || txtAutor.Text != (biblio2.Autor) && txtAutor.Text != "" || txtAutor.Text != (biblio3.Autor) && txtAutor.Text != "")
                {
                    MessageBox.Show("No se encontraron resultados.", "Búsqueda");
                    txtLibro.Clear();
                    txtAutor.Clear();
                }
                else
                {
                    validarVacios();
                }
            }
        }
            //int coincidencia = 0;
            /*
            string[,] VBiblioteca;
            VBiblioteca = new string[4, 3];

            //Código Libro-Autor-Ublicación-Estado
            VBiblioteca[0, 0] = "Se busca una mujer"; VBiblioteca[1, 0] = "Charles Bukowski"; VBiblioteca[2, 0] = "Literatura novelezca área 1.A"; VBiblioteca[3, 0] = "En préstamo";
            VBiblioteca[0, 1] = "Ortografía"; VBiblioteca[1, 1] = "Gonzalo Ándres Muñoz"; VBiblioteca[2, 1] = "Lengua española área 2.T"; VBiblioteca[3, 1] = "Disponible";
            VBiblioteca[0, 2] = "El festival de la blasfemia"; VBiblioteca[1, 2] = "Dross Rotzank"; VBiblioteca[2, 2] = "Literatura Horror área 3.R"; VBiblioteca[3, 2] = "Disponible";
            
            for (i = 0; i <= VBiblioteca.Length; i++)
            {
                
                if (VBiblioteca[0, i].Contains(txtLibro.Text.ToString()))
                {
                    coincidencia++;
                    dgvLibros.Rows.Add(VBiblioteca[0, i], VBiblioteca[1, i], VBiblioteca[2, i], VBiblioteca[3, i]);
                }
            }
            */         
        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
